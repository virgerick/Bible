using System.Collections.Generic;

namespace Bible.Application.Responses.Identity;

public class GetAllRolesResponse
{
    public IEnumerable<RoleResponse> Roles { get; set; }
}