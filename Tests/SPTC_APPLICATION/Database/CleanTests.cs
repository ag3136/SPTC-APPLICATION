using Xunit;

namespace SPTC_APPLICATION.Database
{
    public class CleanTests
    {
        [Fact]
        public void Constructor_CreatesInstance()
        {
            var clean = new Clean("tbl_sample");
            Assert.NotNull(clean);
        }

        [Fact]
        public void Start_WhenNotAdmin_ReturnsFalse()
        {
            var original = AppState.IS_ADMIN;
            try
            {
                AppState.IS_ADMIN = false;
                var clean = new Clean("tbl_sample");
                Assert.False(clean.Start());
            }
            finally
            {
                AppState.IS_ADMIN = original;
            }
        }
    }
}
