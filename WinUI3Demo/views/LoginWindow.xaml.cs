using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        public  LoginViewModel loginViewModel;
        public LoginWindow() {
            loginViewModel = new LoginViewModel();

            this.InitializeComponent();

            AppWindow appWindow = this.AppWindow;
            appWindow.Resize(new Windows.Graphics.SizeInt32(600, 600));
        }

        public async void LoginButton_Click(object sender, RoutedEventArgs args) {
            loginViewModel.CheckCredentials();

            LoginResponse loginResponse = loginViewModel.LoginResponse;
            if (loginResponse.ResultCode == ResultCode.OK) {
                MainWindow userDashboard = new MainWindow();

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
