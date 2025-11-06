
using System;
using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória")]
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero")]
        public int QuantidadeEstoque { get; set; }


        public DateTime CriadoEm { get; set; } = DateTime.Now;

          public void AtualizarEstoque(int quantidadeVendida)
        {
            QuantidadeEstoque -= quantidadeVendida;
        }
    }
}