# Sistema de Cadastro de Usuários em C# .NET

Este é um projeto de exemplo de um sistema de cadastro de usuários desenvolvido em C# .NET. O sistema permite que você crie, leia, atualize e exclua informações de usuários em um banco de dados.

## Funcionalidades

- Cadastro de usuários com informações básicas, como nome, e-mail e senha.
- Listagem de usuários cadastrados.
- Edição de informações de usuários.
- Exclusão de usuários.

## Pré-requisitos

- [Visual Studio](https://visualstudio.microsoft.com/) ou outro ambiente de desenvolvimento C# .NET.
- [SQL Server](https://www.microsoft.com/sql-server) ou outro banco de dados compatível.
- [.NET Framework](https://dotnet.microsoft.com/) instalado.

## Configuração do Banco de Dados

Antes de executar o programa, é necessário configurar o banco de dados. Siga os passos abaixo:

1. Crie um banco de dados SQL Server ou outro banco de dados de sua escolha.
2. Atualize a string de conexão com o banco de dados no arquivo `appsettings.json` com as informações do seu banco.

## Execute o comando de migração para criar as tabelas do banco de dados:
```dotnet ef database update```
1. Abra o projeto no Visual Studio.

2. Compile o projeto.

3. Execute o programa.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "SuaStringDeConexaoAqui"
  }
}
