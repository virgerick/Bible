using AutoMapper;

using Bible.Application.Features.Brands.Commands.AddEdit;
using Bible.Application.Features.Brands.Queries.GetAll;
using Bible.Domain.Contracts.Queries.GetById;
using Bible.Domain.Entities.Catalog;

namespace Bible.Application.Mappings;

public class BrandProfile : Profile
{
    public BrandProfile()
    {
        CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
        CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
        CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
    }
}