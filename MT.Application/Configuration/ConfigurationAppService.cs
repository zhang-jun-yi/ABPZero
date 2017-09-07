using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MT.Configuration.Dto;

namespace MT.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MTAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
