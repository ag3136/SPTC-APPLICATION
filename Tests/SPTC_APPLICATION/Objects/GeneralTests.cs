using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class GeneralTests
    {
        [Fact]
        public void Name_ToString_UsesWholeName()
        {
            var name = new Name("Mr", "John", "Paul", "Doe", "Jr");
            Assert.Contains("Doe", name.ToString());
            Assert.Contains("John", name.ToString());
        }

        [Fact]
        public void Address_ToString_WithAddressLines_ReturnsCombinedValue()
        {
            var address = new Address("Line1", "Line2");
            Assert.Equal("Line1 Line2", address.ToString());
        }

        [Fact]
        public void Address_ToString_WithStructuredAddress_ReturnsFormattedValue()
        {
            var address = new Address("12", "Main", "Barangay", "City", "1000", "Province", "Country");
            Assert.Contains("12 Main", address.ToString());
            Assert.Contains("City", address.ToString());
        }

        [Fact]
        public void Image_ToString_ReturnsName()
        {
            var image = new Image(new byte[] { 1, 2, 3 }, "photo");
            Assert.Equal("photo", image.ToString());
        }

        [Fact]
        public void Position_ToString_ReturnsTitle()
        {
            var position = new Position("Manager", true, false, true);
            Assert.Equal("Manager", position.ToString());
        }

        [Fact]
        public void ViolationType_ToString_ReturnsTitle()
        {
            var violationType = new ViolationType("Late", "Details", 3, true);
            Assert.Equal("Late", violationType.ToString());
        }
    }
}
