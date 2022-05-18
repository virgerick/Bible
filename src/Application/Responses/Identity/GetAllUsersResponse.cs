using System.Collections.Generic;

namespace Bible.Application.Responses.Identity;

public class GetAllUsersResponse
{
    public IEnumerable<UserResponse> Users { get; set; }
}