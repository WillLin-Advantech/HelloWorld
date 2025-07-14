using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HelloWorld.Pages;

[Collection(HelloWorldTestConsts.CollectionDefinitionName)]
public class Index_Tests : HelloWorldWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
