using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class ViolationTests
    {
        [Fact]
        public void Constructor_CreatesInstance()
        {
            var violation = new Violation();
            Assert.NotNull(violation);
        }
    }
}
