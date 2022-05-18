using AutoMapper;

using Bible.Application.Features.Products.Commands.AddEdit;
using Bible.Domain.Entities.Catalog;

namespace Bible.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}