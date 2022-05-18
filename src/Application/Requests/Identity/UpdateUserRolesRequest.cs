using System.Collections.Generic;

using Bible.Application.Responses.Identity;

namespace Bible.Application.Requests.Identity;

public class UpdateUserRolesRequest
{
    public string UserId { get; set; }
    public IList<UserRoleModel> UserRoles { get; set; }
}