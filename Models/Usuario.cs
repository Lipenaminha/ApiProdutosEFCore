
using ApiProdutos.Enums;

namespace ApiProdutos.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }  = Role.User; // padrão é "User"
    }
}