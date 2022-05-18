﻿using System.Collections.Generic;

namespace Bible.Application.Requests.Identity;

public class PermissionRequest
{
    public string RoleId { get; set; }
    public IList<RoleClaimRequest> RoleClaims { get; set; }
}