using Bible.Domain.Entities.ExtendedAttributes;
using Bible.Domain.Entities.Misc;

using Microsoft.Extensions.Localization;

namespace Bible.Application.Validators.Features.ExtendedAttributes.Commands.AddEdit;

public class AddEditDocumentExtendedAttributeCommandValidator : AddEditExtendedAttributeCommandValidator<int, int, Document, DocumentExtendedAttribute>
{
    public AddEditDocumentExtendedAttributeCommandValidator(IStringLocalizer<AddEditExtendedAttributeCommandValidatorLocalization> localizer) : base(localizer)
    {
        // you can override the validation rules here
    }
}