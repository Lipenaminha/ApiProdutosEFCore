using ApiProdutos.Models;

using ApiProdutos.Data;

namespace ApiProdutos.Services.ClienteService
{
    

    public class ClienteService
    {
        private readonly AppDbContext _context;

        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void RemoverCliente(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

        public Cliente? ObterClientePorId(int id)
        {
            return _context.Clientes.Find(id);
        }

        public List<Cliente> ObterTodosClientes()
        {
            return _context.Clientes.ToList();
        }
    }
} 



