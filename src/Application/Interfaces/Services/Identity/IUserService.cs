﻿using Bible.Application.Interfaces.Common;
using Bible.Application.Requests.Identity;
using Bible.Application.Responses.Identity;

using Shared.Wrapper;

namespace Bible.Application.Interfaces.Services.Identity;

public interface IUserService : IService
{
    Task<Result<List<UserResponse>>> GetAllAsync();

    Task<int> GetCountAsync();

    Task<IResult<UserResponse>> GetAsync(string userId);

    Task<IResult> RegisterAsync(RegisterRequest request, string origin);

    Task<IResult> ToggleUserStatusAsync(ToggleUserStatusRequest request);

    Task<IResult<UserRolesResponse>> GetRolesAsync(string id);

    Task<IResult> UpdateRolesAsync(UpdateUserRolesRequest request);

    Task<IResult<string>> ConfirmEmailAsync(string userId, string code);

    Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);

    Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);

    Task<string> ExportToExcelAsync(string searchString = "");
}