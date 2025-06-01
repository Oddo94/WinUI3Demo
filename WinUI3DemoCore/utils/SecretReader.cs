using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    dbConnectionString = null;
                    break;
            }

           return dbConnectionString;
        }
    }
}
