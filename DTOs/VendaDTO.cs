namespace ApiProdutos.DTOs
{
    public class VendaDTO
    {
        public int ProdutoId { get; set; }

        public int ClienteId { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataVenda { get; set; } // Data da venda
    }
}