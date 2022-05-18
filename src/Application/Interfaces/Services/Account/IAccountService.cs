using Bible.Application.Interfaces.Common;
using Bible.Application.Requests.Identity;

using Shared.Wrapper;

namespace Bible.Application.Interfaces.Services.Account;
public interface IAccountService : IService
{
    Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

    Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

    Task<IResult<string>> GetProfilePictureAsync(string userId);

    Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
}