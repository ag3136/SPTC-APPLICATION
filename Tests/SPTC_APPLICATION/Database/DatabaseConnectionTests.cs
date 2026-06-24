using Xunit;

namespace SPTC_APPLICATION.Database
{
    public class DatabaseConnectionTests
    {
        [Fact]
        public void Constructor_StoresConnectionStringForGetConnection()
        {
            _ = new DatabaseConnection("Server=localhost;Database=test;Uid=user;Pwd=pass;");
            var connection = DatabaseConnection.GetConnection();
            Assert.NotNull(connection);
            Assert.Contains("Server=localhost", connection.ConnectionString);
        }

        [Fact]
        public void GetEnumDescription_ReturnsDescriptionAttribute()
        {
            var description = DatabaseConnection.GetEnumDescription(ConnectionLogs.STRING_EMPTY);
            Assert.Equal("Empty Connection string", description);
        }

        [Fact]
        public void Builder_Connect_WithInvalidServer_ReturnsFalse()
        {
            var builder = new DatabaseConnection.Builder("invalid-host", "3306", "db", "user", "pass");
            var result = builder.Connect();
            Assert.False(result);
            Assert.True(builder.Log == ConnectionLogs.CANNOT_CONNECT || builder.Log == ConnectionLogs.EXCEPTION_OCCURED || builder.Log == ConnectionLogs.WRONG_PASSWORD);
        }
    }
}
