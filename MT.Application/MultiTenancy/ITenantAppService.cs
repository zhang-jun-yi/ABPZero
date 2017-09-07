using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MT.MultiTenancy.Dto;

namespace MT.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
