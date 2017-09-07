using System.Threading.Tasks;
using Abp.Application.Services;
using MT.Sessions.Dto;

namespace MT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
