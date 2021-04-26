using System.Collections.Generic;
using Haha.Roles.Dto;

namespace Haha.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}