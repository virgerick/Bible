using AutoMapper;

using Bible.Application.Features.DocumentTypes.Commands.AddEdit;
using Bible.Application.Features.DocumentTypes.Queries.GetAll;
using Bible.Application.Features.DocumentTypes.Queries.GetById;
using Bible.Domain.Entities.Misc;

namespace Bible.Application.Mappings;

public class DocumentTypeProfile : Profile
{
    public DocumentTypeProfile()
    {
        CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
        CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
        CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
    }
}