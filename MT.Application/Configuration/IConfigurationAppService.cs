using System.Threading.Tasks;
using Abp.Application.Services;
using MT.Configuration.Dto;

namespace MT.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}