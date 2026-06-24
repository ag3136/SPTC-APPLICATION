using System;
using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class DriverTests
    {
        [Fact]
        public void Constructor_InitializesWithNullReferences()
        {
            var driver = new Driver();
            Assert.Null(driver.name);
            Assert.Null(driver.address);
            Assert.Null(driver.image);
            Assert.Null(driver.signature);
        }

        [Fact]
        public void WriteInto_AssignsAllProperties()
        {
            var driver = new Driver();
            var name = new Name("Mr", "John", "Q", "Public", "");
            var address = new Address("Line1", "Line2");
            var image = new Image(new byte[] { 1 }, "img");
            var sign = new Image(new byte[] { 2 }, "sig");
            var birthday = new DateTime(2000, 1, 1);

            var result = driver.WriteInto(name, address, image, sign, "remarks", birthday, "Jane", "123", false);

            Assert.True(result);
            Assert.Equal(name, driver.name);
            Assert.Equal(address, driver.address);
            Assert.Equal(image, driver.image);
            Assert.Equal(sign, driver.signature);
            Assert.Equal("remarks", driver.remarks);
            Assert.Equal(birthday, driver.birthday);
            Assert.Equal("Jane", driver.emergencyPerson);
            Assert.Equal("123", driver.emergencyContact);
            Assert.False(driver.isDayShift);
        }

        [Fact]
        public void ToString_WithoutName_ReturnsEmptyString()
        {
            var driver = new Driver();
            Assert.Equal(string.Empty, driver.ToString());
        }

        [Fact]
        public void ToString_WithName_ReturnsNameString()
        {
            var driver = new Driver();
            driver.name = new Name("Mr", "John", "Q", "Public", "");
            Assert.Contains("Public", driver.ToString());
        }
    }
}
