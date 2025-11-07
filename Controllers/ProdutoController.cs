using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Models;
using ApiProdutos.Services.ProdutoService;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using ApiProdutos.DTOs;
using ApiProdutos.Enums;

namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _service;

        private readonly IMapper _mapper;

        public ProdutoController(ProdutoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")] // apenas admins podem acessar
        public IActionResult Listar()
        {
            var produtos = _service.ObterTodosProdutos();
            var produtosDto = _mapper.Map<List<ProdutoDTO>>(produtos); // Model → DTO
            return Ok(produtosDto);
        }

        [HttpPost]
         [Authorize(Roles = "Admin")] // Apenas admins podem criar
        public IActionResult Adicionar([FromBody] ProdutoDTO produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _service.AdicionarProduto(produto);
            return Ok("Produto adicionado com sucesso!");
        }

       [HttpPut("{id}")]
[Authorize(Roles = "Admin")]
public IActionResult Atualizar(int id, [FromBody] ProdutoDTO produtoDto)
{
    if (id != produtoDto.Id)
        return BadRequest("O ID da URL não corresponde ao ID do produto.");

    var produto = _mapper.Map<Produto>(produtoDto);
    _service.AtualizarProduto(produto);
    return Ok("Produto atualizado com sucesso!");
}

        [HttpDelete("{id}")]
          [Authorize(Roles = "Admin")] // Apenas admins podem deletar
        public IActionResult Remover(int id)
        {
            _service.RemoverProduto(id);
            return Ok("Produto removido!");
        }
    }
}
