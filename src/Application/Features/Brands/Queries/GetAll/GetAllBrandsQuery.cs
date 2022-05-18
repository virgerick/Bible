using AutoMapper;

using Bible.Application.Interfaces.Repositories;
using Bible.Domain.Entities.Catalog;
using Bible.Shared.Constants.Application;

using LazyCache;

using MediatR;

using Shared.Wrapper;

namespace Bible.Application.Features.Brands.Queries.GetAll;

public class GetAllBrandsQuery : IRequest<Result<List<GetAllBrandsResponse>>>
{
    public GetAllBrandsQuery()
    {
    }
}

internal class GetAllBrandsCachedQueryHandler : IRequestHandler<GetAllBrandsQuery, Result<List<GetAllBrandsResponse>>>
{
    private readonly IUnitOfWork<int> _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAppCache _cache;

    public GetAllBrandsCachedQueryHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IAppCache cache)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cache = cache;
    }

    public async Task<Result<List<GetAllBrandsResponse>>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
    {
        Func<Task<List<Brand>>> getAllBrands = () => _unitOfWork.Repository<Brand>().GetAllAsync();
        var brandList = await _cache.GetOrAddAsync(ApplicationConstants.Cache.GetAllBrandsCacheKey, getAllBrands);
        var mappedBrands = _mapper.Map<List<GetAllBrandsResponse>>(brandList);
        return await Result<List<GetAllBrandsResponse>>.SuccessAsync(mappedBrands);
    }
}