# API de Produtos 🛒

![SQL](https://img.shields.io/badge/sqlite-4479A1.svg?style=for-the-badge&logo=sql&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)

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
| GET    | `/produtos`         | Lista todos os produtos           | 
| GET    | `/produtos/{id}`    | Retorna produto pelo ID           | 
| POST   | `/produtos`         | Cria novo produto                 |
| PUT    | `/produtos/{id}`    | Atualiza produto existente        | 
| DELETE | `/produtos/{id}`    | Deleta produto pelo ID            | 

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
![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white).