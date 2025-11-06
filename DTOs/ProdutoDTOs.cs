


namespace ApiProdutos.DTOs
{
    public class ProdutoDTO
    {

        public string Nome { get; set; } = string.Empty;

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

         public DateTime CriadoEm { get; set; } // precisa estar aqui



    }
}