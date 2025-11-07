



using ApiProdutos.Models;
using ApiProdutos.Services;
using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

   [HttpPost("login")]
public IActionResult Login([FromBody] Usuario usuario)
{
    if (usuario.Username == "admin" && usuario.Password == "admin")
    {
        usuario.Role = ApiProdutos.Enums.Role.Admin; // ✅ ADMIN verdadeiro
        var token = _jwtService.GenerateToken(usuario);
        return Ok(new { Token = token });
    }
    else if (usuario.Username == "user" && usuario.Password == "user")
    {
        usuario.Role = ApiProdutos.Enums.Role.User; // ✅ usuário comum
        var token = _jwtService.GenerateToken(usuario);
        return Ok(new { Token = token });
    }

    return Unauthorized("Usuário ou senha inválidos");
}
}