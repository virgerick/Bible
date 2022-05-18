﻿using AutoMapper;

using Bible.Application.Interfaces.Repositories;
using Bible.Domain.Entities.Misc;
using Bible.Shared.Constants.Application;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

using Shared.Wrapper;

using System.ComponentModel.DataAnnotations;

namespace Bible.Application.Features.DocumentTypes.Commands.AddEdit
{
    public class AddEditDocumentTypeCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }

    internal class AddEditDocumentTypeCommandHandler : IRequestHandler<AddEditDocumentTypeCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<AddEditDocumentTypeCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public AddEditDocumentTypeCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditDocumentTypeCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditDocumentTypeCommand command, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.Repository<DocumentType>().Entities.Where(p => p.Id != command.Id)
                .AnyAsync(p => p.Name == command.Name, cancellationToken))
            {
                return await Result<int>.FailAsync(_localizer["Document type with this name already exists."]);
            }

            if (command.Id == 0)
            {
                var documentType = _mapper.Map<DocumentType>(command);
                await _unitOfWork.Repository<DocumentType>().AddAsync(documentType);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllDocumentTypesCacheKey);
                return await Result<int>.SuccessAsync(documentType.Id, _localizer["Document Type Saved"]);
            }
            else
            {
                var documentType = await _unitOfWork.Repository<DocumentType>().GetByIdAsync(command.Id);
                if (documentType != null)
                {
                    documentType.Name = command.Name ?? documentType.Name;
                    documentType.Description = command.Description ?? documentType.Description;
                    await _unitOfWork.Repository<DocumentType>().UpdateAsync(documentType);
                    await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllDocumentTypesCacheKey);
                    return await Result<int>.SuccessAsync(documentType.Id, _localizer["Document Type Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Document Type Not Found!"]);
                }
            }
        }
    }
}