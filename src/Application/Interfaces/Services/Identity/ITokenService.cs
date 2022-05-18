using Bible.Application.Interfaces.Common;
using Bible.Application.Requests.Identity;
using Bible.Application.Responses.Identity;

using Shared.Wrapper;

namespace Bible.Application.Interfaces.Services.Identity;

public interface ITokenService : IService
{
    Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

    Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
}