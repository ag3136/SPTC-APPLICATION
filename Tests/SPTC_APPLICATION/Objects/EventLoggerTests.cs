using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class EventLoggerTests
    {
        [Fact]
        public void CountLines_WithNull_ReturnsZero()
        {
            Assert.Equal(0, StringExtensions.CountLines(null));
        }

        [Fact]
        public void CountLines_WithSingleLine_ReturnsOne()
        {
            Assert.Equal(1, "line".CountLines());
        }

        [Fact]
        public void CountLines_WithMultipleLines_ReturnsExpectedCount()
        {
            var text = string.Join(System.Environment.NewLine, new[] { "a", "b", "c" });
            Assert.Equal(3, text.CountLines());
        }
    }
}
