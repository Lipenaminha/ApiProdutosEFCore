using Microsoft.AspNetCore.Mvc;

using ApiProdutos.Services.VendaService;
using ApiProdutos.Models;


namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaService _service;

        public VendaController(VendaService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AdicionarVenda([FromBody] Venda venda)
        {
            _service.AdicionarVenda(venda);
            return Ok("Venda adicionada com sucesso!");
        }

        [HttpGet]
        public IActionResult ObterTodasVendas()
        {
            var vendas = _service.ObterTodasVendas();
            return Ok(vendas);
        }
    }
} 
