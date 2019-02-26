using System.Management.Automation;
using Xunit;

namespace IntelliTect.Cmdlet.Starter.Tests
{
    public class GetExampleTests
    {
        [Fact]
        public void GetExample_Test()
        {
            var sut = new GetExample();

            Assert.IsAssignableFrom<PSCmdlet>(sut);
        }
    }
}