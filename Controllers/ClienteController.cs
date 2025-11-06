using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Services.ClienteService;
using ApiProdutos.Models;


namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        public ClienteController(ClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var clientes = _service.ObterTodosClientes();
            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Adicionar(Cliente cliente)
        {
            _service.AdicionarCliente(cliente);
            return Ok("Cliente adicionado com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(Cliente cliente)
        {
            _service.AtualizarCliente(cliente);
            return Ok("Cliente atualizado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _service.RemoverCliente(id);
            return Ok("Cliente removido!");
        }
    }
}