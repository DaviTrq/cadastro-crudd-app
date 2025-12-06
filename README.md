# Cadastro CRUD App

Aplicação Windows Forms simples para gerenciar cadastros com campos: email, senha, nome e observação.

Requisitos
- .NET 10 SDK
- Visual Studio 2022/2023 (recomendado) ou `dotnet` CLI

Como rodar
- Usando Visual Studio: abra a solução e pressione F5.
- Usando CLI:
  - `dotnet build`
  - `dotnet run --project cadastro-crud-app.csproj`

Git
- Já existe `.gitignore` no projeto; o arquivo `cadastros.json` está ignorado para não vazar dados locais.
- Comandos úteis:
  - `git init`
  - `git add .`
  - `git commit -m "inic commit: CRUD de cadastros"`
  - criar repositório remoto e `git remote add origin <url>`
  - `git push -u origin main`

Uso da aplicação
- Preencha `email`, `senha`, `nome` e `observacao` e clique `+` para adicionar.
- Selecione um item e clique `Editar` ou dê duplo-clique para carregar nos campos; depois clique `Salvar` para atualizar.
- Selecione um item e clique `X` para excluir.

Observações e próximos passos
- `cadastros.json` guarda os registros localmente em JSON (sem criptografia de senhas). Considere usar armazenamento seguro e hashing de senhas para produção.
- Se quiser, posso adicionar confirmação de exclusão, busca/filtragem, exportação/importação ou criptografia das senhas.

Contato
- Projeto gerado localmente. Para subir ao GitHub, siga os passos em "Git" acima.
