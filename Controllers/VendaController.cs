using Microsoft.AspNetCore.Mvc;

using ApiProdutos.Services.VendaService;
using ApiProdutos.Models;
using AutoMapper;
using ApiProdutos.DTOs;


namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaService _service;

        private readonly IMapper _mapper;

        public VendaController(VendaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarVenda([FromBody] VendaDTO vendaDto)
        {
            var venda = _mapper.Map<Venda>(vendaDto); // transforma DTO em Model
            _service.AdicionarVenda(venda);
            return Ok("Venda adicionada com sucesso!");
        }

        [HttpGet]
        public IActionResult ObterTodasVendas()
        {
            var vendas = _service.ObterTodasVendas();
            var vendasDto = _mapper.Map<List<VendaDTO>>(vendas); // Model → DTO
            return Ok(vendasDto);
        }
    }
} 
