using System;
using System.IO;
using Xunit;

namespace SPTC_APPLICATION
{
    public class AppStateTests
    {
        [Fact]
        public void SaveToJson_CreatesFileWithConfiguredValues()
        {
            var originalPath = AppState.APPSTATE_PATH;
            var originalPassword = AppState.DEFAULT_PASSWORD;
            var originalAddress = AppState.DEFAULT_ADDRESSLINE2;
            var originalExpiration = AppState.EXPIRATION_DATE;
            var originalChairman = AppState.CHAIRMAN;
            var originalRegistration = AppState.REGISTRATION_NO;
            var originalAdjustments = AppState.PRINT_AJUSTMENTS;

            var tempDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"));
            var tempFile = Path.Combine(tempDirectory, "AppState.json");

            try
            {
                AppState.APPSTATE_PATH = tempFile;
                AppState.DEFAULT_PASSWORD = "Secret!";
                AppState.DEFAULT_ADDRESSLINE2 = "Address";
                AppState.EXPIRATION_DATE = "2025";
                AppState.CHAIRMAN = "Chair";
                AppState.REGISTRATION_NO = "REG-1";
                AppState.PRINT_AJUSTMENTS = 12.5;

                AppState.SaveToJson();

                Assert.True(File.Exists(tempFile));
                var json = File.ReadAllText(tempFile);
                Assert.Contains("Secret!", json);
                Assert.Contains("REG-1", json);
            }
            finally
            {
                AppState.APPSTATE_PATH = originalPath;
                AppState.DEFAULT_PASSWORD = originalPassword;
                AppState.DEFAULT_ADDRESSLINE2 = originalAddress;
                AppState.EXPIRATION_DATE = originalExpiration;
                AppState.CHAIRMAN = originalChairman;
                AppState.REGISTRATION_NO = originalRegistration;
                AppState.PRINT_AJUSTMENTS = originalAdjustments;
                if (Directory.Exists(tempDirectory)) Directory.Delete(tempDirectory, true);
            }
        }

        [Fact]
        public void LoadFromJson_WhenFileMissing_DoesNotThrow()
        {
            var originalPath = AppState.APPSTATE_PATH;
            try
            {
                AppState.APPSTATE_PATH = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N"), "missing.json");
                AppState.LoadFromJson();
                Assert.True(true);
            }
            finally
            {
                AppState.APPSTATE_PATH = originalPath;
            }
        }
    }
}
