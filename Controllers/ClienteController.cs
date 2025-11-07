using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Services.ClienteService;
using ApiProdutos.Models;
using ApiProdutos.DTOs;
using AutoMapper;


namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _service;

        private readonly IMapper _mapper;

        public ClienteController(ClienteService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var clientes = _service.ObterTodosClientes();
            var clientesDto = _mapper.Map<List<ClienteDTO>>(clientes);
            return Ok(clientesDto);
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] ClienteDTO clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            _service.AdicionarCliente(cliente);
            return Ok("Cliente adicionado com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCliente([FromBody] ClienteDTO clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
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