using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace stackTest.Pages
{
    public class Index_Tests : stackTestWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
