
# ✅ API de Tarefas – Desafio DIO (Trilha .NET)

![Cover](cover.png)

Bem-vindo ao repositório da **API de Gerenciamento de Tarefas**, desenvolvida como parte do **Desafio de Projeto da Trilha .NET da Digital Innovation One (DIO)**.

Este projeto implementa uma **API REST completa**, utilizando:

* ✅ **.NET 6+**
* ✅ **Entity Framework Core**
* ✅ **SQLite** (banco de dados simples para desenvolvimento)
* ✅ **Swagger** para documentação automática
* ✅ Arquitetura limpa e organizada

---

# 🎯 Objetivo do Projeto

Criar um sistema simples para **gerenciamento de tarefas**, permitindo:

* Criar tarefas
* Listar todas as tarefas
* Consultar tarefa por ID
* Filtrar tarefas por título, data ou status
* Atualizar tarefa existente
* Excluir tarefa

Tudo isso usando **CRUD completo + filtros especiais**, conforme solicitado no desafio.

---

# 📌 Tecnologias Utilizadas

* ASP.NET Core Web API
* Entity Framework Core
* SQLite
* Swagger (OpenAPI)

---

# 🗂️ Estrutura do Projeto

```
📦 desafio_api_tarefas
 ┣ 📁 Controllers
 ┃ ┗ 📄 TarefasController.cs
 ┣ 📁 Data
 ┃ ┗ 📄 AppDbContext.cs
 ┣ 📁 Models
 ┃ ┗ 📄 Tarefa.cs
 ┣ 📄 Program.cs
 ┣ 📄 appsettings.json
 ┣ 📄 README.md
 ┗ 📄 cover.png
```

---

# 🛠️ Como executar o projeto

## ✅ 1. Restaurar dependências

```bash
dotnet restore
```

## ✅ 2. Criar o banco de dados (EF Core)

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

> Após isso, será criado o arquivo **tarefas.db**.

## ✅ 3. Executar a API

```bash
dotnet run
```

## ✅ 4. Abrir o Swagger

Acesse:

```
https://localhost:5001/swagger
```

---

# 🔥 Endpoints Disponíveis

## ✅ **GET /tarefa/ObterTodos**

Retorna todas as tarefas.

## ✅ **GET /tarefa/{id}**

Retorna uma tarefa pelo ID.

## ✅ **GET /tarefa/ObterPorTitulo?titulo=...**

Busca tarefas que contêm o título informado.

## ✅ **GET /tarefa/ObterPorData?data=AAAA-MM-DD**

Filtra tarefas por data.

## ✅ **GET /tarefa/ObterPorStatus?status=Pendente**

Filtra tarefas por status.

## ✅ **POST /tarefa**

Cria uma nova tarefa.

### Exemplo de JSON:

```json
{
  "titulo": "Comprar café",
  "descricao": "Ir ao mercado comprar café",
  "data": "2025-11-09T12:00:00",
  "status": "Pendente"
}
```

## ✅ **PUT /tarefa/{id}**

Atualiza uma tarefa existente.

## ✅ **DELETE /tarefa/{id}
