using AutoMapper;
using CleanArchitectura.Core.Entities;
using CleanArchitecture.Application.Commands;
using CleanArchitecture.Application.Responses;

namespace CleanArchitecture.Application.Mappers
{
    public class ProductMappingProfile: Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
        }
    }
}
