using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using WinUI3DemoCore.model;
using WinUI3DemoCore.utils;
using WinUI3DemoCore.view_model;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3Demo.views {
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginWindow : Window {
        private  LoginViewModel loginViewModel;
        private MainWindow userDashboard;

        public LoginWindow(LoginViewModel loginViewModel, MainWindow userDashboard) {
            this.loginViewModel = loginViewModel;
            this.userDashboard = userDashboard;

            this.InitializeComponent();

            AppWindow appWindow = this.AppWindow;
            appWindow.Resize(new Windows.Graphics.SizeInt32(600, 600));
        }

        public async void LoginButton_Click(object sender, RoutedEventArgs args) {
            loginViewModel.CheckCredentials();

            //LoginResponse loginResponse = loginViewModel.LoginResponse;
            LoginResponse loginResponse = new LoginResponse(ResultCode.OK, "User successfully logged in");//ONLY FOR TESTING PURPOSES!!
            if (loginResponse.ResultCode == ResultCode.OK) {
                this.Close();
                userDashboard.Activate();
            } else {
                ContentDialog loginErrorDialog = new ContentDialog { 
                    Title = "Login", 
                    Content = loginResponse.ResponseMessage, 
                    CloseButtonText = "OK" 
                };

                loginErrorDialog.XamlRoot = this.Content.XamlRoot;
                await loginErrorDialog.ShowAsync();
            }
        }
    }
}
