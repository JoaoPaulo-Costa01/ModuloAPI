# [Nome do Projeto - Ex: CRUD de Clientes]

![C#](https://img.shields.io/badge/C%23-11.0-blue.svg)
![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet.svg)
![Entity%20Framework](https://img.shields.io/badge/Entity%20Framework-Core-orange.svg)
![SQL%20Server](https://img.shields.io/badge/SQL%20Server-2022-red.svg)

## 📄 Sobre o Projeto

Este é um projeto de estudo desenvolvido para praticar e demonstrar os conceitos fundamentais do desenvolvimento backend com o ecossistema .NET.

A aplicação implementa um **CRUD** (Create, Read, Update, Delete) completo, utilizando **C#**, **Entity Framework Core** como ORM para o mapeamento objeto-relacional e o **SQL Server** como sistema de gerenciamento de banco de dados.

O objetivo principal foi solidificar o conhecimento em operações de banco de dados, configuração de projetos .NET e a arquitetura de aplicações de dados.

---

## ✨ Funcionalidades

O projeto permite gerenciar [entidades, ex: usuários, produtos, tarefas], com as seguintes operações:

-   ✅ **Create**: Cadastrar um(a) novo(a) [entidade] no banco de dados.
-   ✅ **Read**: Listar todos(as) os(as) [entidades] cadastrados(as) e buscar um(a) por ID.
-   ✅ **Update**: Atualizar as informações de um(a) [entidade] existente.
-   ✅ **Delete**: Remover um(a) [entidade] do banco de dados.

---

## 🛠️ Tecnologias Utilizadas

As seguintes ferramentas e tecnologias foram utilizadas na construção do projeto:

-   **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)**: Linguagem de programação principal.
-   **[.NET 8](https://dotnet.microsoft.com/pt-br/)**: Framework de desenvolvimento.
-   **[Entity Framework Core 8](https://learn.microsoft.com/pt-br/ef/core/)**: ORM para interação com o banco de dados.
-   **[SQL Server](https://www.microsoft.com/pt-br/sql-server)**: Banco de dados relacional.
-   **[Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/)**: IDE de desenvolvimento.

---

## 🚀 Como Executar o Projeto

Siga os passos abaixo para executar o projeto em seu ambiente local.

### Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina:
-   [.NET SDK 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0) ou superior.
-   [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) (versão Express ou Developer é suficiente).
-   Uma IDE de sua preferência, como [Visual Studio](https://visualstudio.microsoft.com/pt-br/) ou [VS Code](https://code.visualstudio.com/).

### Instalação e Configuração

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/seu-repositorio.git](https://github.com/seu-usuario/seu-repositorio.git)
    ```

2.  **Navegue até a pasta do projeto:**
    ```bash
    cd seu-repositorio
    ```

3.  **Configure a Connection String:**
    Abra o arquivo `appsettings.json` e altere a `DefaultConnection` para apontar para a sua instância do SQL Server.
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=SEU_SERVIDOR;Database=NomeDoSeuBanco;Trusted_Connection=True;TrustServerCertificate=True;"
    }
    ```

4.  **Aplique as Migrations:**
    No terminal, dentro da pasta do projeto, execute o comando abaixo para que o Entity Framework crie o banco de dados e as tabelas necessárias.
    ```bash
    dotnet ef database update
    ```

5.  **Execute a Aplicação:**
    ```bash
    dotnet run
    ```
    A aplicação estará rodando em `http://localhost:5000` (ou outra porta definida no projeto).
