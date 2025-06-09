using Google.Protobuf.WellKnownTypes;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Devices.PointOfService;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinUI3Demo {
    public class MainViewModel {
        public ObservableCollection<Expense> ExpenseList { get; set; }
        public ISeries[] Series { get; set; }

        //public ICartesianAxis[] XAxes { get; set; }

        public ICartesianAxis[] XAxes2 = new Axis[]
{
    new Axis
    {
        // Use the labels property to define named labels.
        Labels = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
}
};

        public ObservableCollection<ISeries> PieSeries { get; set; } = new ObservableCollection<ISeries> {
            new PieSeries<double>  {
                Values = new double[] {200.49 },
                Name = "Utilities"
            },
                new PieSeries<double>  {
                Values = new double[] {500.50 },
                Name = "Entertainment"
            },
                  new PieSeries<double>  {
                Values = new double[] {1000 },
                Name = "Food"
            },
                    new PieSeries<double>  {
                Values = new double[] {288.99},
                Name = "Sport"
            },
                      new PieSeries<double>  {
                Values = new double[] {1.99 },
                Name = "Others"
            },
                        new PieSeries<double>  {
                Values = new double[] {1.80 },
                Name = "Gifts"
            },
                          new PieSeries<double>  {
                Values = new double[] {45.39 },
                Name = "Banking fees"
            },
            };

        public MainViewModel() {
            ExpenseList = new ObservableCollection<Expense>
          {
                //new Expense { name = "Coffee", type = "Variable", value = 3.50, date = "2025-04-09" },
                //new Expense { name = "Lunch", type = "Variable", value = 15.75, date = "2025-04-08" },
                //new Expense { name = "Transport", type = "Variable",  value = 5.00, date = "2025-04-07" },
                //new Expense { name = "Coffee", type = "Variable",  value = 3.50, date = "2025-04-09" },
                //new Expense {name = "Lunch", type = "Variable", value = 15.75, date = "2025-04-08"},
                //new Expense {name = "Transport", type = "Variable", value = 5.00, date = "2025-04-07"},
                //new Expense {name = "Coffee", type = "Variable", value = 3.50, date = "2025-04-09"},
                //new Expense {name = "Lunch", type = "Variable", value = 15.75, date = "2025-04-08"},
                //new Expense {name = "Transport", type = "Variable", value = 5.00, date = "2025-04-07"},
                //new Expense { name = "Coffee", type = "Variable", value = 3.50, date = "2025-04-09" },
                //new Expense { name = "Lunch", type = "Variable", value = 15.75, date = "2025-04-08" },
                //new Expense { name = "Transport", type = "Variable",  value = 5.00, date = "2025-04-07" },
                //new Expense { name = "Coffee", type = "Variable",  value = 3.50, date = "2025-04-09" },
                //new Expense {name = "Lunch", type = "Variable", value = 15.75, date = "2025-04-08"},
                //new Expense {name = "Transport", type = "Variable", value = 5.00, date = "2025-04-07"},
                //new Expense {name = "Coffee", type = "Variable", value = 3.50, date = "2025-04-09"},
                //new Expense {name = "Lunch", type = "Variable", value = 15.75, date = "2025-04-08"},
                //new Expense {name = "Transport", type = "Variable", value = 5.00, date = "2025-04-07"}
                new Expense("Transport", "Variable", 5.00,"2025-04-07")
            };

            Series = new ISeries[] {
                 new ColumnSeries<int>(50, 100, 400, 300, 500, 800, 600, 1000, 700, 1500, 1200, 2500),
            };

            //XAxes = new List<Axis> {
            //    new Axis {
            //        Labels = new string[] {"January", "February", "March", "April", "June", "July", "August"}
            //    }
            //};

            //Series = [
            //    new ColumnSeries<DateTimePoint> {
            //        Values = [
            //            new () {DateTime = new(2025, 1, 1), Value = 50},
            //            new () {DateTime = new(2025, 2, 1), Value = 100},
            //            new () {DateTime = new(2025, 3, 1), Value = 400},
            //            new () {DateTime = new(2025, 4, 1), Value = 800},
            //            new () {DateTime = new(2025, 5, 1), Value = 700},
            //            new () {DateTime = new(2025, 6, 1), Value = 1500},
            //            new () {DateTime = new(2025, 7, 1), Value = 300},
            //            new () {DateTime = new(2025, 8, 1), Value = 900},
            //            new () {DateTime = new(2025, 9, 1), Value = 600},
            //            new () {DateTime = new(2025, 10, 1), Value = 1100},
            //            new () {DateTime = new(2025, 11, 1), Value = 500},
            //            new () {DateTime = new(2025, 12, 1), Value = 1900},
            //            ]
            //    }

            //    ];
        }
        //        public ICartesianAxis[] XAxes { get; set; } = [
        //  new DateTimeAxis(TimeSpan.FromDays(1), date => date.ToString("MMM"))
        //];
    }
}
