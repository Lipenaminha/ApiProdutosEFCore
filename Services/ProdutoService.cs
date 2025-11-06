using ApiProdutos.Models;

using ApiProdutos.Data;


namespace ApiProdutos.Services.ProdutoService
{
    public class ProdutoService
    {
        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void RemoverProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
        }

        public Produto? ObterProdutoPorId(int id)
        {
            return _context.Produtos.Find(id);
        }

        public List<Produto> ObterTodosProdutos()
        {
            return _context.Produtos.ToList();
        }
    }

}