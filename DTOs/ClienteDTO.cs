namespace ApiProdutos.DTOs
{
    public class ClienteDTO
    {
        public string Nome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public DateTime CriadoEm { get; set; } // Mantemos para controle de quando o cliente foi criado
    }
}