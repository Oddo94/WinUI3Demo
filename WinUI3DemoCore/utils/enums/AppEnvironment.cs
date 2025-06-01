using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3DemoCore.utils.enums {
    public enum AppEnvironment {
        [Description("PROD")]
        PROD,
        [Description("TEST")]
        TEST,
        [Description("DEV")]
        DEV,
        [Description("UNDEFINED")]
        UNDEFINED
    }

    public static class AppEnvironmentExtensions {
        public static AppEnvironment GetByDescription(string appEnvDescription) {
            AppEnvironment appEnvironment;

            switch(appEnvDescription) {
                case "PROD":
                    appEnvironment = AppEnvironment.PROD;
                    break;

                case "TEST":
                    appEnvironment = AppEnvironment.TEST;
                    break;

                case "DEV":
                    appEnvironment = AppEnvironment.DEV;
                    break;

                default:
                    appEnvironment = AppEnvironment.UNDEFINED;
                    break;
            }
            
            return appEnvironment;
        }
    }
}

