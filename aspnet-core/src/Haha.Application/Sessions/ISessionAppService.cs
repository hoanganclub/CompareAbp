using System.Threading.Tasks;
using Abp.Application.Services;
using Haha.Sessions.Dto;

namespace Haha.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
