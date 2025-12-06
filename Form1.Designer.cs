namespace cadastro_crud_app
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel painelVidro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListView listViewCadastros;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colObservacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer animaTimer;
        private System.Windows.Forms.Button btnAlterar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            painelVidro = new Panel();
            lblTitulo = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtObservacao = new TextBox();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnAlterar = new Button();
            listViewCadastros = new ListView();
            colId = new ColumnHeader();
            colEmail = new ColumnHeader();
            colNome = new ColumnHeader();
            colObservacao = new ColumnHeader();
            animaTimer = new System.Windows.Forms.Timer(components);
            painelVidro.SuspendLayout();
            SuspendLayout();
            // 
            // painelVidro
            // 
            painelVidro.BackColor = Color.FromArgb(50, 255, 255, 255);
            painelVidro.Controls.Add(lblTitulo);
            painelVidro.Controls.Add(txtEmail);
            painelVidro.Controls.Add(txtSenha);
            painelVidro.Controls.Add(txtNome);
            painelVidro.Controls.Add(txtObservacao);
            painelVidro.Controls.Add(btnAdicionar);
            painelVidro.Controls.Add(btnExcluir);
            painelVidro.Controls.Add(btnAlterar);
            painelVidro.Controls.Add(listViewCadastros);
            painelVidro.Location = new Point(50, 40);
            painelVidro.Name = "painelVidro";
            painelVidro.Size = new Size(820, 520);
            painelVidro.TabIndex = 0;
            painelVidro.Paint += PainelVidro_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(35, 35, 35);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(30, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@exemplo.com";
            txtEmail.Size = new Size(320, 20);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(35, 35, 35);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(30, 110);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "senha";
            txtSenha.Size = new Size(320, 20);
            txtSenha.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(35, 35, 35);
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.ForeColor = Color.White;
            txtNome.Location = new Point(30, 150);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "nome";
            txtNome.Size = new Size(320, 20);
            txtNome.TabIndex = 3;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(35, 35, 35);
            txtObservacao.BorderStyle = BorderStyle.None;
            txtObservacao.ForeColor = Color.White;
            txtObservacao.Location = new Point(30, 190);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PlaceholderText = "observacao";
            txtObservacao.Size = new Size(320, 80);
            txtObservacao.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(90, 40, 180);
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(370, 70);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(60, 40);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += BtnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(180, 40, 40);
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(370, 120);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(60, 40);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "X";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(64, 64, 64);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI", 12F);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(370, 230);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(84, 40);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Editar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += BtnAlterar_Click_Logic;
            // 
            // listViewCadastros
            // 
            listViewCadastros.BackColor = Color.FromArgb(20, 20, 20);
            listViewCadastros.Columns.AddRange(new ColumnHeader[] { colId, colEmail, colNome, colObservacao });
            listViewCadastros.ForeColor = Color.White;
            listViewCadastros.FullRowSelect = true;
            listViewCadastros.Location = new Point(460, 60);
            listViewCadastros.Name = "listViewCadastros";
            listViewCadastros.Size = new Size(330, 380);
            listViewCadastros.TabIndex = 8;
            listViewCadastros.UseCompatibleStateImageBehavior = false;
            listViewCadastros.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "#";
            colId.Width = 30;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 120;
            // 
            // colNome
            // 
            colNome.Text = "Nome";
            colNome.Width = 100;
            // 
            // colObservacao
            // 
            colObservacao.Text = "Observacao";
            colObservacao.Width = 80;
            // 
            // animaTimer
            // 
            animaTimer.Interval = 30;
            animaTimer.Tick += AnimaTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(920, 600);
            Controls.Add(painelVidro);
            Name = "Form1";
            Text = "Cadastro moderninho";
            Load += Form1_Load;
            painelVidro.ResumeLayout(false);
            painelVidro.PerformLayout();
            ResumeLayout(false);
        }

        private void PainelVidro_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = painelVidro.ClientRectangle;
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(rect, System.Drawing.Color.FromArgb(80, 60, 60, 60), System.Drawing.Color.FromArgb(30, 40, 40, 40), 45f))
            {
                g.FillRectangle(brush, rect);
            }
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(120, 255, 255, 255)))
            {
                g.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1);
            }
        }

        private float brilho = 0.0f;

        private void AnimaTimer_Tick(object sender, EventArgs e)
        {
            // efeito discreto, sem alterar alpha para não piscar
            brilho += 0.01f;
            if (brilho > 1.0f) brilho = 0.0f;
            // manter cor estável, pequena variação de tonalidade
            var cinza = 40 + (int)(6 * Math.Sin(brilho * Math.PI * 2));
            painelVidro.BackColor = System.Drawing.Color.FromArgb(80, cinza, cinza, cinza);
            painelVidro.Invalidate();
        }
    }
}
