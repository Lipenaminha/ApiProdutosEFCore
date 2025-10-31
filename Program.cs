using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ProdutosDB.db")
);

var app = builder.Build();

// ❌ sem EnsureCreated — banco será criado via migração!

// GET - Listar todos os produtos
app.MapGet("/produtos", async (AppDbContext db) =>
    await db.Produtos.ToListAsync()
);

// GET - Buscar produto por ID
app.MapGet("/produtos/{id}", async (int id, AppDbContext db) =>
    await db.Produtos.FindAsync(id)
        is Produto p ? Results.Ok(p) : Results.NotFound()
);

// POST - Criar novo produto
app.MapPost("/produtos", async (Produto p, AppDbContext db) =>
{
    db.Produtos.Add(p);
    await db.SaveChangesAsync();
    return Results.Created($"/produtos/{p.Id}", p);
});

// PUT - Atualizar produto existente
app.MapPut("/produtos/{id}", async (int id, Produto p, AppDbContext db) =>
{
    var prod = await db.Produtos.FindAsync(id);
    if (prod == null) return Results.NotFound();

    prod.Nome = p.Nome;
    prod.Preco = p.Preco;
    prod.Quantidade = p.Quantidade;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

// DELETE - Remover produto
app.MapDelete("/produtos/{id}", async (int id, AppDbContext db) =>
{
    var prod = await db.Produtos.FindAsync(id);
    if (prod == null) return Results.NotFound();

    db.Produtos.Remove(prod);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();