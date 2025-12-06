using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace cadastro_crud_app
{
    public partial class Form1 : Form
    {
        private List<Cadastro> lista = new List<Cadastro>();
        private string arquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cadastros.json");
        private int selecionadoId = 0;

        public void IniciaLogica()
        {
            CarregaDados();
            AtualizaListView();
            listViewCadastros.DoubleClick += ListViewCadastros_DoubleClick;
            btnAlterar.Click += BtnAlterar_Click_Logic;
        }

        private void BtnAlterar_Click_Logic(object sender, EventArgs e)
        {
            if (listViewCadastros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(listViewCadastros.SelectedItems[0].Text, out int id)) return;
            var item = lista.FirstOrDefault(x => x.Id == id);
            if (item == null) return;
            txtEmail.Text = item.Email;
            txtSenha.Text = item.Senha;
            txtNome.Text = item.Nome;
            txtObservacao.Text = item.Observacao;
            selecionadoId = id;
            btnAdicionar.Text = "Salvar";
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (selecionadoId > 0)
            {
                var item = lista.FirstOrDefault(x => x.Id == selecionadoId);
                if (item != null)
                {
                    item.Email = txtEmail.Text.Trim();
                    item.Senha = txtSenha.Text;
                    item.Nome = txtNome.Text.Trim();
                    item.Observacao = txtObservacao.Text.Trim();
                    if (string.IsNullOrWhiteSpace(item.Email) || string.IsNullOrWhiteSpace(item.Senha))
                    {
                        MessageBox.Show("Preencha email e senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SalvaDados();
                    AtualizaListView();
                    LimpaCampos();
                    return;
                }
            }

            var novo = new Cadastro();
            novo.Id = lista.Any() ? lista.Max(x => x.Id) + 1 : 1;
            novo.Email = txtEmail.Text.Trim();
            novo.Senha = txtSenha.Text;
            novo.Nome = txtNome.Text.Trim();
            novo.Observacao = txtObservacao.Text.Trim();
            if (string.IsNullOrWhiteSpace(novo.Email) || string.IsNullOrWhiteSpace(novo.Senha))
            {
                MessageBox.Show("Preencha email e senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lista.Add(novo);
            SalvaDados();
            AtualizaListView();
            LimpaCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (listViewCadastros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(listViewCadastros.SelectedItems[0].Text, out int id)) return;
            var item = lista.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                lista.Remove(item);
                if (selecionadoId == id) LimpaCampos();
                SalvaDados();
                AtualizaListView();
            }
        }

        private void ListViewCadastros_DoubleClick(object sender, EventArgs e)
        {
            if (listViewCadastros.SelectedItems.Count == 0) return;
            if (!int.TryParse(listViewCadastros.SelectedItems[0].Text, out int id)) return;
            var item = lista.FirstOrDefault(x => x.Id == id);
            if (item == null) return;
            txtEmail.Text = item.Email;
            txtSenha.Text = item.Senha;
            txtNome.Text = item.Nome;
            txtObservacao.Text = item.Observacao;
            selecionadoId = id;
            btnAdicionar.Text = "Salvar";
        }

        private void CarregaDados()
        {
            try
            {
                if (!File.Exists(arquivo)) return;
                var json = File.ReadAllText(arquivo);
                lista = JsonSerializer.Deserialize<List<Cadastro>>(json) ?? new List<Cadastro>();
            }
            catch
            {
                lista = new List<Cadastro>();
            }
        }

        private void SalvaDados()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(lista, options);
                File.WriteAllText(arquivo, json);
            }
            catch
            {
            }
        }

        private void AtualizaListView()
        {
            listViewCadastros.Items.Clear();
            foreach (var c in lista)
            {
                var l = new ListViewItem(c.Id.ToString());
                l.SubItems.Add(c.Email);
                l.SubItems.Add(c.Nome);
                l.SubItems.Add(c.Observacao);
                listViewCadastros.Items.Add(l);
            }
        }

        private void LimpaCampos()
        {
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtObservacao.Text = "";
            selecionadoId = 0;
            btnAdicionar.Text = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciaLogica();
        }
    }
}
