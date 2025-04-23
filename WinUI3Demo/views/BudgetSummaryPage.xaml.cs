using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using WinUI3DemoCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.Kernel.Sketches;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BudgetSummaryPage : Page
    {
        MainViewModel viewModel;

        BudgetSummaryViewModel coreViewModel;
        LiveChartsViewModelWrapper coreModelWrapper;

        public BudgetSummaryPage()
        {
            this.InitializeComponent();
            this.viewModel = new MainViewModel();

            this.coreViewModel = new BudgetSummaryViewModel();
            this.coreModelWrapper = new LiveChartsViewModelWrapper(coreViewModel);
        }

        public void Button_Click(object sender, RoutedEventArgs e) {
            Console.WriteLine("Inside 'Button_Click' method");
            if ("This is a test message".Equals(sampleTextBlock.Text)) {
                sampleTextBlock.Text = "You clicked the button!";
            } else {
                sampleTextBlock.Text = "This is a test message";
            }

            coreModelWrapper.XAxis.Clear();
            coreModelWrapper.XAxis.Add(new Axis() {
                Labels = new string[] {
                                "JAN",
                                "FEB",
                                "MAR",
                                "APR",
                                "MAY",
                                "JUN",
                                "JUL",
                                "AUG",
                                "SEP",
                                "OCT",
                                "NOV",
                                "DEC"
                            }
            });
        }

                    public void LowercaseButton_Click(object sender, RoutedEventArgs e) {
            ICartesianAxis newAxis = new Axis() {
                Labels = new string[] {
                                "Jan",
                                "Feb",
                                "Mar",
                                "Apr",
                                "May",
                                "Jun",
                                "Jul",
                                "Aug",
                                "Sep",
                                "Oct",
                                "Nov",
                                "Dec"
                            }
            };

            setAxis(coreModelWrapper.XAxis, newAxis);
        }

        public void ChangeChartDataButton_Click(object sender, RoutedEventArgs e) {
            //coreViewModel.updateData();

            //ObservableCollection<DataPoint> updatedCollection = coreViewModel.Series;
            //List<double> seriesList = new List<double>();

            //foreach (DataPoint currentPoint in updatedCollection) {
            //    seriesList.Add(currentPoint.Value);
            //}

            //coreModelWrapper.Series.Clear();
            //coreModelWrapper.Series.Add(new ColumnSeries<double>(values: seriesList.ToArray()));
        }

        public void setAxis(ObservableCollection<ICartesianAxis> existingCollection, ICartesianAxis newAxis) {
            if (existingCollection != null) {
                existingCollection.Clear();
                existingCollection.Add(newAxis);
            }
        }
    }
}
