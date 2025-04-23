using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using WinUI3DemoCore.model;

namespace WinUI3DemoCore {
    public partial class BudgetSummaryViewModel : INotifyPropertyChanged {
        //[ObservableProperty]
        //public partial ObservableCollection<Expense> expenseList { get; set; }
        public ObservableCollection<DataPoint> Series { get; set; }

        //public ICartesianAxis[] XAxes { get; set; }

        //        public ICartesianAxis[] xAxes2 = new Axis[]
        //{
        //    new Axis
        //    {
        //        // Use the labels property to define named labels.
        //        Labels = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
        //}
        //};

        //public ObservableCollection<ISeries> PieSeries { get; set; } = new ObservableCollection<ISeries> {
        //    new PieSeries<double>  {
        //        Values = new double[] {200.49 },
        //        Name = "Utilities"
        //    },
        //        new PieSeries<double>  {
        //        Values = new double[] {500.50 },
        //        Name = "Entertainment"
        //    },
        //          new PieSeries<double>  {
        //        Values = new double[] {1000 },
        //        Name = "Food"
        //    },
        //            new PieSeries<double>  {
        //        Values = new double[] {288.99},
        //        Name = "Sport"
        //    },
        //              new PieSeries<double>  {
        //        Values = new double[] {1.99 },
        //        Name = "Others"
        //    },
        //                new PieSeries<double>  {
        //        Values = new double[] {1.80 },
        //        Name = "Gifts"
        //    },
        //                  new PieSeries<double>  {
        //        Values = new double[] {45.39 },
        //        Name = "Banking fees"
        //    },
        //    };

        public BudgetSummaryViewModel() {
            //  ExpenseList = new ObservableCollection<Expense>
            //{
            //      new Expense { name = "Coffee", type = "Variable", user= "Razvan", amount = 3.50, date = "2025-04-09" },
            //      new Expense { name = "Lunch", type = "Variable", user= "Razvan", amount = 15.75, date = "2025-04-08" },
            //      new Expense { name = "Transport", type = "Variable", user= "Razvan",  amount = 5.00, date = "2025-04-07" },
            //      new Expense { name = "Coffee", type = "Variable", user= "Razvan",  amount = 3.50, date = "2025-04-09" },
            //      new Expense {name = "Lunch", type = "Variable", user = "Razvan", amount = 15.75, date = "2025-04-08"},
            //      new Expense {name = "Transport", type = "Variable", user = "Razvan", amount = 5.00, date = "2025-04-07"},
            //      new Expense {name = "Coffee", type = "Variable", user = "Razvan", amount = 3.50, date = "2025-04-09"},
            //      new Expense {name = "Lunch", type = "Variable", user = "Razvan", amount = 15.75, date = "2025-04-08"},
            //      new Expense {name = "Transport", type = "Variable", user = "Razvan ", amount = 5.00, date = "2025-04-07"}
            //  };

            this.Series = new ObservableCollection<DataPoint> {
                new DataPoint("Jan", 4000),
                new DataPoint("Feb", 3000),
                new DataPoint("Mar", 2000),
                new DataPoint("Apr", 300),
                new DataPoint("May", 500),
                new DataPoint("Jun", 800),
                new DataPoint("Jul", 600),
                new DataPoint("Aug", 1000),
                new DataPoint("Sep", 700),
                new DataPoint("Oct", 1500),
                new DataPoint("Nov", 1200),
                new DataPoint("Dec", 2500)
            };

        }

        public void updateData(int userId, int year) {
            //DataPoint point = this.Series[0];

            //if (point.Value == 4000) {
            //    this.Series = new ObservableCollection<DataPoint> {
            //    new DataPoint("Jan", 1200),
            //    new DataPoint("Feb", 1100),
            //    new DataPoint("Mar", 1000),
            //    new DataPoint("Apr", 900),
            //    new DataPoint("May", 800),
            //    new DataPoint("Jun", 700),
            //    new DataPoint("Jul", 600),
            //    new DataPoint("Aug", 500),
            //    new DataPoint("Sep", 400),
            //    new DataPoint("Oct", 300),
            //    new DataPoint("Nov", 200),
            //    new DataPoint("Dec", 100)
            //};
            //} else {
            //    this.Series = new ObservableCollection<DataPoint> {
            //    new DataPoint("Jan", 4000),
            //    new DataPoint("Feb", 3000),
            //    new DataPoint("Mar", 2000),
            //    new DataPoint("Apr", 300),
            //    new DataPoint("May", 500),
            //    new DataPoint("Jun", 800),
            //    new DataPoint("Jul", 600),
            //    new DataPoint("Aug", 1000),
            //    new DataPoint("Sep", 700),
            //    new DataPoint("Oct", 1500),
            //    new DataPoint("Nov", 1200),
            //    new DataPoint("Dec", 2500)
            //};
            //}

            List<double> seriesList;

            switch (year) {
                case 2025:
                    this.Series = new ObservableCollection<DataPoint> {
                new DataPoint("Jan", 2000),
                new DataPoint("Feb", 1900),
                new DataPoint("Mar", 1800),
                new DataPoint("Apr", 1700),
                new DataPoint("May", 1600),
                new DataPoint("Jun", 1500),
                new DataPoint("Jul", 1400),
                new DataPoint("Aug", 1300),
                new DataPoint("Sep", 1200),
                new DataPoint("Oct", 1100),
                new DataPoint("Nov", 1000),
                new DataPoint("Dec", 900) };
                    break;
                case 2024:
                    this.Series = new ObservableCollection<DataPoint> {
                new DataPoint("Jan", 100),
                new DataPoint("Feb", 200),
                new DataPoint("Mar", 300),
                new DataPoint("Apr", 400),
                new DataPoint("May", 500),
                new DataPoint("Jun", 600),
                new DataPoint("Jul", 700),
                new DataPoint("Aug", 800),
                new DataPoint("Sep", 900),
                new DataPoint("Oct", 1000),
                new DataPoint("Nov", 1100),
                new DataPoint("Dec", 1200) };
                    break;

                case 2023:
                    this.Series = new ObservableCollection<DataPoint> {
                new DataPoint("Jan", 1000),
                new DataPoint("Feb", 1100),
                new DataPoint("Mar", 1200),
                new DataPoint("Apr", 1300),
                new DataPoint("May", 1400),
                new DataPoint("Jun", 1500),
                new DataPoint("Jul", 1700),
                new DataPoint("Aug", 1400),
                new DataPoint("Sep", 1300),
                new DataPoint("Oct", 1200),
                new DataPoint("Nov", 1100),
                new DataPoint("Dec", 1000) };
                    break;

                default:
                    this.Series = new ObservableCollection<DataPoint> {
                new DataPoint("Jan", 100),
                new DataPoint("Feb", 200),
                new DataPoint("Mar", 200),
                new DataPoint("Apr", 100),
                new DataPoint("May", 300),
                new DataPoint("Jun", 300),
                new DataPoint("Jul", 200),
                new DataPoint("Aug", 400),
                new DataPoint("Sep", 400),
                new DataPoint("Oct", 300),
                new DataPoint("Nov", 500),
                new DataPoint("Dec", 500) };
                    break;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
