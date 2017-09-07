using System.Threading.Tasks;
using Abp.Application.Services;
using MT.Authorization.Accounts.Dto;

namespace MT.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
