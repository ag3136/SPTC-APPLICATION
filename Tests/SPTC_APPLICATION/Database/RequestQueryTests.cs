using Xunit;

namespace SPTC_APPLICATION.Database
{
    public class RequestQueryTests
    {
        [Fact]
        public void Protect_ReturnsMd5Hash()
        {
            var hash = RequestQuery.Protect("hello");
            Assert.Equal("5d41402abc4b2a76b9719d911017c592", hash);
        }

        [Fact]
        public void GetEnumDescription_ReturnsCrudDescription()
        {
            var description = RequestQuery.GetEnumDescription(CRUDControl.LOGIN_FAILED);
            Assert.Equal("LOGIN FAILED", description);
        }

        [Fact]
        public void TableConstants_ArePopulated()
        {
            Assert.False(string.IsNullOrWhiteSpace(Table.EMPLOYEE));
            Assert.False(string.IsNullOrWhiteSpace(Field.PASSWORD));
            Assert.False(string.IsNullOrWhiteSpace(Where.ALL));
        }
    }
}
