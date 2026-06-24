using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class FranchiseTests
    {
        [Fact]
        public void Constructor_InitializesReferencePropertiesToNull()
        {
            var franchise = new Franchise();
            Assert.Null(franchise.Operator);
            Assert.Null(franchise.Driver_day);
            Assert.Null(franchise.Driver_night);
            Assert.Null(franchise.owner);
            Assert.Null(franchise.lastFranchiseId);
        }

        [Fact]
        public void WriteInto_AssignsProperties()
        {
            var franchise = new Franchise();
            var op = new Operator();
            var day = new Driver();
            var night = new Driver();

            var result = franchise.WriteInto("B1", op, day, night, "LIC-1");

            Assert.True(result);
            Assert.Equal("B1", franchise.bodynumber);
            Assert.Equal(op, franchise.Operator);
            Assert.Equal(day, franchise.Driver_day);
            Assert.Equal(night, franchise.Driver_night);
            Assert.Equal("LIC-1", franchise.licenceNO);
        }

        [Fact]
        public void ToString_WithoutBodyNumber_ReturnsEmptyString()
        {
            Assert.Equal(string.Empty, new Franchise().ToString());
        }
    }
}
