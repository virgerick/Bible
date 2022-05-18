

using Bible.Application.Interfaces.Common;

namespace Bible.Application.Interfaces.Services;

public interface ICurrentUserService : IService
{
    string UserId { get; }
}