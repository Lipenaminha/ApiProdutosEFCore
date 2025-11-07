using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProdutos.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarQuantidadeNaVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuantidadeEstoque",
                table: "Vendas",
                newName: "Quantidade");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Vendas",
                newName: "QuantidadeEstoque");
        }
    }
}
