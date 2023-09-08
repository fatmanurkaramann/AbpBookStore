using System.Threading.Tasks;
using Abp.BookStore.Models.TokenAuth;
using Abp.BookStore.Web.Controllers;
using Shouldly;
using Xunit;

namespace Abp.BookStore.Web.Tests.Controllers
{
    public class HomeController_Tests: BookStoreWebTestBase
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