using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Haha.Configuration.Dto;

namespace Haha.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HahaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
