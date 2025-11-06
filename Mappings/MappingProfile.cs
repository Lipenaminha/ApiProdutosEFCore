using AutoMapper;
using ApiProdutos.Models;
using ApiProdutos.DTOs;

namespace ApiProdutos.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}