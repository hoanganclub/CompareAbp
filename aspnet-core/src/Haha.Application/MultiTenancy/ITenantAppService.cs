using Abp.Application.Services;
using Haha.MultiTenancy.Dto;

namespace Haha.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

