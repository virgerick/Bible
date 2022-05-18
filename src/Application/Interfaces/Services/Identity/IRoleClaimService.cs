using Bible.Application.Interfaces.Common;
using Bible.Application.Requests.Identity;
using Bible.Application.Responses.Identity;

using Shared.Wrapper;

namespace Bible.Application.Interfaces.Services.Identity;

public interface IRoleClaimService : IService
{
    Task<Result<List<RoleClaimResponse>>> GetAllAsync();

    Task<int> GetCountAsync();

    Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

    Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

    Task<Result<string>> SaveAsync(RoleClaimRequest request);

    Task<Result<string>> DeleteAsync(int id);
}