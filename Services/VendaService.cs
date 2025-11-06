using Microsoft.EntityFrameworkCore;
using ApiProdutos.Data;
using ApiProdutos.Models;

namespace ApiProdutos.Services.VendaService
{

    public class VendaService
    {
        private readonly AppDbContext _context;

        public VendaService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarVenda(Venda venda)
        {
            // Atualiza o estoque do produto vendido
            var produto = _context.Produtos.Find(venda.ProdutoId);
            if (produto != null)
            {
                produto.AtualizarEstoque(venda.QuantidadeEstoque);
                _context.Produtos.Update(produto);
            }

            _context.Vendas.Add(venda);
            _context.SaveChanges();
        }

        public List<Venda> ObterTodasVendas()
        {
            return _context.Vendas
                .Include(v => v.Produto)
                .Include(v => v.Cliente)
                .ToList();
        }


    }
}
