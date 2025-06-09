using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.UI.Xaml;
using System.Windows;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUI3Demo.views;
using Microsoft.Extensions.Configuration;
using WinUI3DemoCore;
using Microsoft.Extensions.Hosting;
using WinUI3DemoCore.view_model;
using Microsoft.Extensions.DependencyInjection;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3Demo
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {
        //private Window? mainWindow;
        private Window? loginWindow;

        public static IHost? AppHost { get; private set; }

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<IBudgetItemViewModel, BudgetSummaryViewModel>();
                    services.AddTransient<LiveChartsViewModelWrapper>();
                    services.AddTransient<MainWindow>();
                    services.AddTransient<LoginViewModel>();
                    services.AddTransient<LoginWindow>();
                })
                .Build();     
        }

        /// <summary>
        /// Invoked when the application is launched.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            //mainWindow = new MainWindow();
            //mainWindow.Activate();

            if (AppHost == null) {
                throw new InvalidOperationException("An error occurred when trying to setup the required objects.");
            }

            loginWindow = AppHost.Services.GetService<LoginWindow>();

            if (loginWindow == null) {
                throw new InvalidOperationException("Unable to initialize the login window!");
            } else {
                loginWindow.Activate();
            }

            // Create a Frame to act as the navigation context and navigate to the first page
            //Frame rootFrame = new Frame();
            //rootFrame.NavigationFailed += OnNavigationFailed;

            // Navigate to the first page, configuring the new page
            // by passing required information as a navigation parameter
            //rootFrame.Navigate(typeof(MainWindow), args.Arguments);

            // Place the frame in the current Window
            //mainWindow.Content = rootFrame;

            // Ensure the MainWindow is active

        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs args) {
            throw new Exception(String.Format("Failed to load page '{0}'", args.SourcePageType.FullName));
        }  
    }
}
