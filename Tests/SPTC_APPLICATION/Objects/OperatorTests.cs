using System;
using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class OperatorTests
    {
        [Fact]
        public void Constructor_InitializesReferencePropertiesToNull()
        {
            var op = new Operator();
            Assert.Null(op.name);
            Assert.Null(op.address);
            Assert.Null(op.image);
            Assert.Null(op.signature);
        }

        [Fact]
        public void WriteInto_AssignsProperties()
        {
            var op = new Operator();
            var name = new Name("Mr", "John", "Q", "Public", "");
            var address = new Address("Line1", "Line2");
            var image = new Image(new byte[] { 1 }, "img");
            var sign = new Image(new byte[] { 2 }, "sig");
            var date = new DateTime(2000, 1, 1);

            var result = op.WriteInto(name, address, image, sign, "remarks", date, "Jane", "123");

            Assert.True(result);
            Assert.Equal(name, op.name);
            Assert.Equal(address, op.address);
            Assert.Equal(image, op.image);
            Assert.Equal(sign, op.signature);
            Assert.Equal("remarks", op.remarks);
        }

        [Fact]
        public void ToString_WithoutName_ReturnsEmptyString()
        {
            Assert.Equal(string.Empty, new Operator().ToString());
        }
    }
}
