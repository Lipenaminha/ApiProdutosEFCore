using Microsoft.EntityFrameworkCore;
using ApiProdutos.Data;
using ApiProdutos.Services.ClienteService;
using ApiProdutos.Services.ProdutoService;
using ApiProdutos.Services.VendaService;
using ApiProdutos.Mappings;


var builder = WebApplication.CreateBuilder(args);

// Banco de dados SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=ProdutosDB.db")
);

// Injeção de dependência dos serviços
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ProdutoService>();
builder.Services.AddScoped<VendaService>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Adiciona Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS e Rotas de Controllers
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();