using AutoMapper;

using Bible.Application.Features.ExtendedAttributes.Commands.AddEdit;
using Bible.Application.Features.ExtendedAttributes.Queries.GetAll;
using Bible.Application.Features.ExtendedAttributes.Queries.GetAllByEntityId;
using Bible.Application.Features.ExtendedAttributes.Queries.GetById;
using Bible.Domain.Entities.ExtendedAttributes;

namespace Bible.Application.Mappings;

public class ExtendedAttributeProfile : Profile
{
    public ExtendedAttributeProfile()
    {
        CreateMap(typeof(AddEditExtendedAttributeCommand<,,,>), typeof(DocumentExtendedAttribute))
            .ForMember(nameof(DocumentExtendedAttribute.Entity), opt => opt.Ignore())
            .ForMember(nameof(DocumentExtendedAttribute.CreatedBy), opt => opt.Ignore())
            .ForMember(nameof(DocumentExtendedAttribute.CreatedOn), opt => opt.Ignore())
            .ForMember(nameof(DocumentExtendedAttribute.LastModifiedBy), opt => opt.Ignore())
            .ForMember(nameof(DocumentExtendedAttribute.LastModifiedOn), opt => opt.Ignore());

        CreateMap(typeof(GetExtendedAttributeByIdResponse<,>), typeof(DocumentExtendedAttribute)).ReverseMap();
        CreateMap(typeof(GetAllExtendedAttributesResponse<,>), typeof(DocumentExtendedAttribute)).ReverseMap();
        CreateMap(typeof(GetAllExtendedAttributesByEntityIdResponse<,>), typeof(DocumentExtendedAttribute)).ReverseMap();
    }
}