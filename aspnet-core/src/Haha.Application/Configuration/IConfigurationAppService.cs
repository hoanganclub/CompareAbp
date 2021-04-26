using System.Threading.Tasks;
using Haha.Configuration.Dto;

namespace Haha.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
