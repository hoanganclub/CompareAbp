using System.Collections.Generic;
using Haha.Roles.Dto;

namespace Haha.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
