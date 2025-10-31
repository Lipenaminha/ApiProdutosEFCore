# API de Produtos 🛒

![.NET](https://img.shields.io/badge/.NET-purple?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%20Sharp-blue?style=for-the-badge&logo=c-sharp)
![SQLite](https://img.shields.io/badge/SQLite-green?style=for-the-badge&logo=sqlite)
![API Status](https://img.shields.io/badge/API-black?style=for-the-badge)

API RESTful desenvolvida em **C#** com **ASP.NET Core**, utilizando **Entity Framework Core** com **SQLite**. Permite gerenciar produtos com **CRUD completo**.

---

## Funcionalidades

- Criar produtos  
- Listar todos os produtos  
- Consultar produto por ID  
- Atualizar produto existente  
- Deletar produtos  

---

## Tecnologias Utilizadas

- **C#**  
- **.NET 7**  
- **ASP.NET Core Web API**  
- **Entity Framework Core**  
- **SQLite**  
- **Visual Studio / VS Code**  

---

## Estrutura do Projeto

- `Produto.cs` – Model do produto  
- `AppDbContext.cs` – Contexto do EF Core  
- `Program.cs` – Configuração da aplicação e endpoints  
- `Migrations/` – Histórico de migrações do EF Core  

---

## Endpoints

| Método | Endpoint             | Descrição                         | Status |
|--------|--------------------|-----------------------------------|--------|
| GET    | `/produtos`         | Lista todos os produtos           | ![GET](https://img.shields.io/badge/GET-OK-brightgreen?style=for-the-badge) |
| GET    | `/produtos/{id}`    | Retorna produto pelo ID           | ![GET](https://img.shields.io/badge/GET-OK-brightgreen?style=for-the-badge) |
| POST   | `/produtos`         | Cria novo produto                 | ![POST](https://img.shields.io/badge/POST-OK-blue?style=for-the-badge) |
| PUT    | `/produtos/{id}`    | Atualiza produto existente        | ![PUT](https://img.shields.io/badge/PUT-OK-yellow?style=for-the-badge) |
| DELETE | `/produtos/{id}`    | Deleta produto pelo ID            | ![DELETE](https://img.shields.io/badge/DELETE-OK-red?style=for-the-badge) |

### Exemplo de JSON para POST/PUT

 ```json
{
  "nome": "Produto Exemplo",
  "preco": 49.90,
  "quantidade": 10
}
```

### Como Executar 

1. Clone o repositório:
git clone https://github.com/seu-usuario/ApiProdutos.git

2. Entre na pasta do projeto:
cd ApiProdutos

3. Restaure as dependências:
dotnet restore

4. Crie o banco de dados aplicando as migrações:
dotnet tool
dotnet ef migrations add Initial
dotnet ef database update

5. Execute a aplicação: 
dotnet run 

6. Acesse a API em: 
https://localhost:5052/produtos

### Testando a API

Abrir no Postman
 – Simule requisições rapidamente

Swagger UI
 – Se estiver habilitado no projeto

## Licença

Este projeto está licenciado sob 
![License](https://img.shields.io/badge/MIT-black?style=for-the-badge).