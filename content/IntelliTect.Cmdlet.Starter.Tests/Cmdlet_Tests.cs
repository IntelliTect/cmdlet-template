using System.Management.Automation;
using Xunit;

namespace IntelliTect.Cmdlet.Starter.Tests
{
    public class Cmdlet_Tests
    {
        [Fact]
        public void NewCmdlet_Test()
        {
            var sut = new NewCmdlet();

            Assert.IsAssignableFrom<PSCmdlet>(sut);
        }
    }
}