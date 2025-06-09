using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using WinUI.TableView;
using WinUI3DemoCore;

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

            //MyTableView.AutoGeneratingColumn += MyTableView_AutoGeneratingColumn;
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

        //private void MyTableView_AutoGeneratingColumn(object sender, TableViewAutoGeneratingColumnEventArgs e) {
        //    String propertyName = e.Column.

        //    if (propertyName != null) {
        //        e.Column.Header = propertyName;
        //    }


        //}
    }
}
