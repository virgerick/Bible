using AutoMapper;

using Bible.Application.Features.Documents.Commands.AddEdit;
using Bible.Application.Features.Documents.Queries.GetById;

using System.Reflection.Metadata;

namespace Bible.Application.Mappings;

public class DocumentProfile : Profile
{
    public DocumentProfile()
    {
        CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
        CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
    }
}