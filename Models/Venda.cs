


namespace ApiProdutos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        public int QuantidadeEstoque { get; set; }
        public DateTime DataVenda { get; set; } = DateTime.Now;
    }
}
