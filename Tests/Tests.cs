using WebAppProject.Controllers;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void FirstTest()
        {
            var home = new HomeController();

            var actual = home.Index(2, 2);

            Assert.Equal("4", actual);

        }
        
    }
}
