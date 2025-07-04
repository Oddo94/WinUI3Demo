using LiveChartsCore.Kernel.Sketches;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using WinUI3DemoCore.view_model;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3Demo {
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window {
        private readonly MainViewModel viewModel;
        private readonly IBudgetItemViewModel coreViewModel;
        private readonly LiveChartsViewModelWrapper coreModelWrapper;

        public MainWindow(IBudgetItemViewModel coreViewModel, LiveChartsViewModelWrapper coreModelWrapper) {
            this.InitializeComponent();
            this.viewModel = new MainViewModel();

            //this.coreViewModel = new BudgetSummaryViewModel();
            //this.coreModelWrapper = new LiveChartsViewModelWrapper(coreViewModel);


            this.coreViewModel = coreViewModel;
            this.coreModelWrapper = coreModelWrapper;

            contentFrame.Navigate(typeof(BudgetSummaryPage));
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            if (args.SelectedItem is NavigationViewItem selectedItem) {
                String? pageName = selectedItem.Tag.ToString();

                switch (pageName) {
                    case "incomesPage":
                        contentFrame.Navigate(typeof(IncomesPage), null);
                        break;

                    case "expensesPage":
                        contentFrame.Navigate(typeof(ExpensesPage), null);
                        break;

                    case "budgetSummaryPage":
                        contentFrame.Navigate(typeof(BudgetSummaryPage), null);
                        break;

                    default:
                        break;
                }
            }
        }

        //public void Button_Click(object sender, RoutedEventArgs e) {
        //    Console.WriteLine("Inside 'Button_Click' method");
        //    if("This is a test message".Equals(sampleTextBlock.Text)) {
        //        sampleTextBlock.Text = "You clicked the button!";
        //    } else {
        //        sampleTextBlock.Text = "This is a test message";
        //    }

        //    coreModelWrapper.XAxis.Clear();
        //    coreModelWrapper.XAxis.Add(              new Axis() {
        //        Labels = new string[] {
        //                        "JAN",
        //                        "FEB",
        //                        "MAR",
        //                        "APR",
        //                        "MAY",
        //                        "JUN",
        //                        "JUL",
        //                        "AUG",
        //                        "SEP",
        //                        "OCT",
        //                        "NOV",
        //                        "DEC"
        //                    }
        //    });


        //        try {
        //            if (coreModelWrapper.XAxis.Count == 0) {
        //                coreModelWrapper.XAxis = new ObservableCollection<ICartesianAxis>() {
        //            new Axis() {
        //                Labels = new string[] {
        //                    "Jan",
        //                    "Feb",
        //                    "Mar",
        //                    "Apr",
        //                    "May",
        //                    "Jun",
        //                    "Jul",
        //                    "Aug",
        //                    "Sep",
        //                    "Oct",
        //                    "Nov",
        //                    "Dec"
        //                }
        //            }

        //        };
        //            } else {
        //            //coreModelWrapper.xAxis.Clear();
        //            coreModelWrapper.XAxis = new ObservableCollection<ICartesianAxis>() {
        //            new Axis() {
        //                Labels = new string[] {
        //                    "JAN",
        //                    "FEB",
        //                    "MAR",
        //                    "APR",
        //                    "MAY",
        //                    "JUN",
        //                    "JUL",
        //                    "AUG",
        //                    "SEP",
        //                    "OCT",
        //                    "NOV",
        //                    "DEC"
        //                }
        //            }

        //        };
        //        }

        //        } catch (Exception ex) {
        //            Console.WriteLine(ex.ToString());
        //        }
        //}

        //public void LowercaseButton_Click(object sender, RoutedEventArgs e) {
        //    ICartesianAxis newAxis = new Axis() {
        //        Labels = new string[] {
        //                        "Jan",
        //                        "Feb",
        //                        "Mar",
        //                        "Apr",
        //                        "May",
        //                        "Jun",
        //                        "Jul",
        //                        "Aug",
        //                        "Sep",
        //                        "Oct",
        //                        "Nov",
        //                        "Dec"
        //                    }
        //    };

        //    setAxis(coreModelWrapper.XAxis, newAxis);
        //}

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

        //public void changeChartData() {
        //    coreViewModel.updateData();

        //    ObservableCollection<DataPoint> updatedCollection = coreViewModel.Series;
        //    List<double> seriesList = new List<double>();

        //    foreach (DataPoint currentPoint in updatedCollection) {
        //        seriesList.Add(currentPoint.Value);
        //    }

        //    coreModelWrapper.Series.Clear();
        //    coreModelWrapper.Series.Add(new ColumnSeries<double>(values: seriesList.ToArray()));
        //}

        public void setAxis(ObservableCollection<ICartesianAxis> existingCollection, ICartesianAxis newAxis) {
            if (existingCollection != null) {
                existingCollection.Clear();
                existingCollection.Add(newAxis);
            }
        }
    }
}

