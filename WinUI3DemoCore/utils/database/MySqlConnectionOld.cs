using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUI3DemoCore.utils.enums;

namespace WinUI3DemoCore.utils.database {
    public class MySqlConnectionOld : IDbConnection {

        private SecretReader secretReader;

        public MySqlConnectionOld () {
            secretReader = new SecretReader();
        }

        public string ConnectionString() {
            string appEnvironmentValue = ConfigurationManager.AppSettings["appEnvironment"] ?? "TEST";//Sets the default value to "TEST" if the extracted value is null

        AppEnvironment appEnvironment = AppEnvironmentExtensions.GetByDescription(appEnvironmentValue);
        string dbConnectionString = secretReader.GetSecret(appEnvironment);
         
            return dbConnectionString;
        }

        public int ConnectionTimeout => throw new NotImplementedException();

        public string Database => throw new NotImplementedException();

        public ConnectionState State => throw new NotImplementedException();

        string IDbConnection.ConnectionString { get => ConnectionString(); set => throw new NotImplementedException(); }

        public IDbTransaction BeginTransaction() {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il) {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName) {
            throw new NotImplementedException();
        }

        public void Close() {
            throw new NotImplementedException();
        }

        public IDbCommand CreateCommand() {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }

        public void Open() {
            throw new NotImplementedException();
        }
    }
}
