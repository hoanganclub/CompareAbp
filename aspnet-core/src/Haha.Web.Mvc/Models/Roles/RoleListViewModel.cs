using System.Collections.Generic;
using Haha.Roles.Dto;

namespace Haha.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
