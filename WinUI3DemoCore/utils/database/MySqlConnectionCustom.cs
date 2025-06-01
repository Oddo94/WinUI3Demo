using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUI3DemoCore.utils.enums;
using MySql.Data;
using System.Configuration;

namespace WinUI3DemoCore.utils.database {
    public class MySqlConnectionCustom : DatabaseConnection {

        private SecretReader secretReader;

        public MySqlConnectionCustom() {
            this.secretReader = new SecretReader();
        }

        public IDbConnection getConnection() {
            string appEnvironmentValue = ConfigurationManager.AppSettings["appEnvironment"] ?? "TEST";//Sets the default value to "TEST" if the extracted value is null

            AppEnvironment appEnvironment = AppEnvironmentExtensions.GetByDescription(appEnvironmentValue);
            string dbConnectionString = secretReader.GetSecret(appEnvironment);

            MySqlConnection conn = new MySqlConnection(dbConnectionString);

            return conn;
        }
    }
}
