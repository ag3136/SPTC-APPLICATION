using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class EmployeeTests
    {
        [Fact]
        public void Constructor_InitializesReferencePropertiesToNull()
        {
            var employee = new Employee();
            Assert.Null(employee.name);
            Assert.Null(employee.address);
            Assert.Null(employee.image);
            Assert.Null(employee.position);
        }
    }
}
