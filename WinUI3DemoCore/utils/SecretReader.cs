using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3DemoCore.utils {
    public class SecretReader {

        public string GetSecret() {
            IConfiguration config = new ConfigurationBuilder()
                .AddUserSecrets<SecretReader>()
                .Build();

           return config["TestDatabaseConnectionString"];
        }
    }
}
