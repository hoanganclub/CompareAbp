using System.Threading.Tasks;
using Haha.Models.TokenAuth;
using Haha.Web.Controllers;
using Shouldly;
using Xunit;

namespace Haha.Web.Tests.Controllers
{
    public class HomeController_Tests: HahaWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}