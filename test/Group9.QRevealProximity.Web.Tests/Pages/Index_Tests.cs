using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Group9.QRevealProximity.Pages;

public class Index_Tests : QRevealProximityWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
