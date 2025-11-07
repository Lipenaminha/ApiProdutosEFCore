using AutoMapper;
using ApiProdutos.Models;
using ApiProdutos.DTOs;

namespace ApiProdutos.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Produto
            CreateMap<Produto, ProdutoDTO>().ReverseMap();

            // Cliente
            CreateMap<Cliente, ClienteDTO>().ReverseMap();

            // Venda
            CreateMap<Venda, VendaDTO>().ReverseMap();
        }
    }
}