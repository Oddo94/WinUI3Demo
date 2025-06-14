
using CommunityToolkit.Mvvm.ComponentModel;
using WinUI3DemoCore.model;
using WinUI3DemoCore.utils;

namespace WinUI3DemoCore.view_model {
    public partial class LoginViewModel : ObservableObject {
        [ObservableProperty]
        private String? userName;

        [ObservableProperty]
        private String? password;

        private LoginResponse loginResponse;

        public LoginViewModel() {
            this.userName = String.Empty;
            this.password = String.Empty;
            this.loginResponse = new LoginResponse();
        }

        public void CheckCredentials() {
            if ("Admin".Equals(UserName) && "MySecretPassword12&@)".Equals(Password)) {
                this.loginResponse = new LoginResponse(ResultCode.OK, String.Empty);
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
