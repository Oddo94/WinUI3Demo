
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUI3DemoCore.model;
using WinUI3DemoCore.utils;

namespace WinUI3DemoCore.view_model {
    public partial class LoginViewModel : ObservableObject {
        [ObservableProperty]
        private String userName;

        [ObservableProperty]
        private String password;

        private LoginResponse loginResponse;

        //[RelayCommand]
        public void CheckCredentials() {
            if ("Admin".Equals(userName) && "MySecretPassword12&@)".Equals(password)) {
                this.loginResponse = new LoginResponse(ResultCode.OK, null);
            } else {
                this.loginResponse = new LoginResponse(ResultCode.ERROR, "Invalid username and/or password!");
            }
        }

        public LoginResponse LoginResponse {
            get { return this.loginResponse; }
            set { this.loginResponse = value; }
        }

    }
}
