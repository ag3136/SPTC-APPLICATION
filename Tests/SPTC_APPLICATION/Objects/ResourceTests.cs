using System.Drawing;
using Xunit;

namespace SPTC_APPLICATION.Objects
{
    public class ResourceTests
    {
        [Fact]
        public void BitmapConversion_ToBitmapSource_ReturnsBitmapSource()
        {
            using var bitmap = new Bitmap(1, 1);
            var source = Resource.BitmapConversion.ToBitmapSource(bitmap);
            Assert.NotNull(source);
        }
    }
}
