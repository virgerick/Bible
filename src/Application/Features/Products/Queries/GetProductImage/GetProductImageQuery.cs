﻿using Bible.Application.Interfaces.Repositories;
using Bible.Domain.Entities.Catalog;

using MediatR;

using Microsoft.EntityFrameworkCore;

using Shared.Wrapper;

namespace Bible.Application.Features.Products.Queries.GetProductImage;

public class GetProductImageQuery : IRequest<Result<string>>
{
    public int Id { get; set; }

    public GetProductImageQuery(int productId)
    {
        Id = productId;
    }
}

internal class GetProductImageQueryHandler : IRequestHandler<GetProductImageQuery, Result<string>>
{
    private readonly IUnitOfWork<int> _unitOfWork;

    public GetProductImageQueryHandler(IUnitOfWork<int> unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<string>> Handle(GetProductImageQuery request, CancellationToken cancellationToken)
    {
        var data = await _unitOfWork.Repository<Product>().Entities.Where(p => p.Id == request.Id).Select(a => a.ImageDataURL).FirstOrDefaultAsync(cancellationToken);
        return await Result<string>.SuccessAsync(data: data);
    }
}