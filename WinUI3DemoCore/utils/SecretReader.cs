using Microsoft.Extensions.Configuration;
using WinUI3DemoCore.utils.enums;

namespace WinUI3DemoCore.utils {
    public class SecretReader {

        public string GetSecret(AppEnvironment appEnvironment) {
            IConfiguration config = new ConfigurationBuilder()
                .AddUserSecrets<SecretReader>()
                .Build();

            string dbConnectionString;

            switch(appEnvironment) {
                case AppEnvironment.PROD:
                    dbConnectionString = config["ProdDatabaseConnectionString"];
                    break;

                case AppEnvironment.TEST:
                    dbConnectionString = config["TestDatabaseConnectionString"];
                    break;

                case AppEnvironment.DEV:
                    dbConnectionString = config["DevDatabaseConnectionString"];
                    break;

                default:
                    dbConnectionString = String.Empty;
                    break;
            }

           return dbConnectionString;
        }
    }
}
