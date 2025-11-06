using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Models;
using ApiProdutos.Services.ProdutoService;

namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _service;

        public ProdutoController(ProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var produtos = _service.ObterTodosProdutos();
            return Ok(produtos);
        }

        [HttpPost]
        public IActionResult Adicionar(Produto produto)
        {
            _service.AdicionarProduto(produto);
            return Ok("Produto adicionado com sucesso!");
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(Produto produto)
        {
            _service.AtualizarProduto(produto);
            return Ok("Produto atualizado com sucesso!");
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _service.RemoverProduto(id);
            return Ok("Produto removido!");
        }
    }
}
