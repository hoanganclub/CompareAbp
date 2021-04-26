using System.Threading.Tasks;
using Abp.Application.Services;
using Haha.Authorization.Accounts.Dto;

namespace Haha.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
