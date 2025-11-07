


namespace ApiProdutos.DTOs
{
    public class ProdutoDTO
    {

         public int Id { get; set; } // ✅ agora o sistema sabe qual produto é

        public string Nome { get; set; } = string.Empty;

        public decimal Preco { get; set; }

        public int QuantidadeEstoque { get; set; }

         public DateTime CriadoEm { get; set; } // precisa estar aqui



    }
}