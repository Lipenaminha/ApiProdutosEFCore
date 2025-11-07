# API de Produtos 🛒

![SQL](https://img.shields.io/badge/sqlite-4479A1.svg?style=for-the-badge&logo=sql&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)

API RESTful desenvolvida em C# com ASP.NET Core 7, utilizando Entity Framework Core com SQLite.
O sistema permite gerenciar Produtos, Clientes e Vendas, com CRUD completo, DTOs, AutoMapper e autenticação JWT.

---

## Funcionalidades

🔐 Autenticação com JWT
Login e geração de token de acesso.
📦 Produtos
Cadastrar, listar, buscar, atualizar e excluir produtos.
👤 Clientes
Gerenciar cadastro de clientes.
💰 Vendas
Registrar vendas, calcular lucro e vincular cliente/produto.
⚙️ Camadas organizadas
Controllers, Services, Models, DTOs e AutoMapper configurados.
💾 Persistência
Banco de dados SQLite com Entity Framework Core.

---

## Tecnologias Utilizadas

#### C#
#### .NET 7 (ASP.NET Core Web API)
#### Entity Framework Core
#### SQLite
#### AutoMapper
#### JWT Authentication
#### Swagger
#### Visual Studio 

---

## Estrutura do Projeto

ApiProdutos/
│
├── Controllers/

│   ├── AuthController.cs
│   ├── ProdutoController.cs
│   ├── ClienteController.cs
│   └── VendaController.cs

│
├── DTOs/

│   ├── ProdutoDTO.cs
│   ├── ClienteDTO.cs
│   └── VendaDTO.cs

│
├── Models/

│   ├── Produto.cs
│   ├── Cliente.cs
│   └── Venda.cs

│
├── Services/

│   ├── ProdutoService.cs
│   ├── ClienteService.cs
│   ├── VendaService.cs
│   └── JwtService.cs

│
├── Data/

│   └── AppDbContext.cs

│
├── Profiles/

│   └── MappingProfile.cs

│
├── Program.cs

└── Migrations/

---


## 🔗 Endpoints Principais

### 🔒 Autenticação
Método	Endpoint	Descrição
POST	/api/auth/login	Login e geração de token

### 📦 Produtos
Método	Endpoint	Descrição
GET	/api/produto	Lista todos os produtos
GET	/api/produto/{id}	Busca produto por ID
POST	/api/produto	Cadastra novo produto
PUT	/api/produto/{id}	Atualiza produto existente
DELETE	/api/produto/{id}	Remove produto

### 👤 Clientes
Método	Endpoint	Descrição
GET	/api/cliente	Lista todos os clientes
GET	/api/cliente/{id}	Busca cliente por ID
POST	/api/cliente	Cadastra novo cliente
PUT	/api/cliente/{id}	Atualiza cliente existente
DELETE	/api/cliente/{id}	Remove cliente

### 💰 Vendas
Método	Endpoint	Descrição
GET	/api/venda	Lista todas as vendas
GET	/api/venda/{id}	Busca venda por ID
POST	/api/venda	Registra nova venda
DELETE	/api/venda/{id}	Remove venda


###  📦 Exemplo de JSON – Criar Produto
{
  "nome": "Camisa Polo",
  "preco": 89.90,
  "quantidade": 20
}

🔑 Exemplo de Login
{
  "usuario": "admin",
  "senha": "123456"
}


Retorno:

{
  "token": "eyJhbGciOiJIUzI1NiIsInR5..."
}


### ⚙️ Como Executar o Projeto

Clone o repositório:
git clone https://github.com/Lipenaminha/ApiProdutosEFCore?tab=readme-ov-file

Entre na pasta:
cd ApiProdutos


Restaure as dependências:
dotnet restore


Crie o banco e aplique migrações:
dotnet ef migrations add Initial
dotnet ef database update


Execute a aplicação:
dotnet run


Acesse no navegador:
https://localhost:5052/swagger

### Testando a API

Abrir no Postman
 – Simule requisições rapidamente

Swagger UI
 – Se estiver habilitado no projeto

 
## Licença

Este projeto está licenciado sob 
![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white).