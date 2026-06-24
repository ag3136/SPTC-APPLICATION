using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class ControllerTests
    {
        [Fact]
        public void CreateEmployee_MethodExists()
        {
            Assert.NotNull(typeof(Controller).GetMethod("CreateEmployee"));
        }
    }
}
