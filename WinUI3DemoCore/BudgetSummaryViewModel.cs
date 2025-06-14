using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using WinUI3DemoCore.model;
using WinUI3DemoCore.utils;
using WinUI3DemoCore.utils.database;
using WinUI3DemoCore.utils.enums;
using WinUI3DemoCore.view_model;

namespace WinUI3DemoCore {
    public partial class BudgetSummaryViewModel : INotifyPropertyChanged, IBudgetItemViewModel {
        //[ObservableProperty]
        //public partial ObservableCollection<Expense> expenseList { get; set; }
        public ObservableCollection<DataPoint> Series { get; set; }

        public string dbConnectionString { get; set;  }

        public event PropertyChangedEventHandler? PropertyChanged;

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
            this.dbConnectionString = String.Empty;
            this.PropertyChanged = delegate { };

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
            //List<double> seriesList;

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

        public void extractDbConnectionString() {

            this.dbConnectionString = new SecretReader().GetSecret(AppEnvironment.TEST);

            MySqlConnection conn = (MySqlConnection)new MySqlConnectionCustom().getConnection();


            try {
                
                String sqlStatementGetExpenses = "SELECT * FROM expenses WHERE YEAR(date) = 2022";
                MySqlCommand getExpensesCommand = new MySqlCommand(sqlStatementGetExpenses);
                getExpensesCommand.Connection = conn;

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getExpensesCommand);

                DataTable expensesDataTable = new DataTable();

                conn.Open();
                dataAdapter.Fill(expensesDataTable);

                foreach(DataRow row in expensesDataTable.Rows) {
                    Debug.WriteLine(String.Format("ExpenseID: {0}; UserID: {1}; Name: {2}; Type: {3}; Value: {4}; Date: {5}", row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4], row.ItemArray[5]));
                }

            } catch (MySqlException ex) {
                Debug.WriteLine(ex.Message);
            } finally {
                conn.Close();
            }
        }

        /// <summary>
        ///  Method for retrieving the list of expenses for the specified time interval 
        /// </summary>
        /// <param name="startDate">The start date of the time interval</param>
        /// <param name="endDate">The end date of the time interval</param>
        /// <returns>The DataTable object containing the retrieved expenses</returns>
        public DataTable GetItemList(DateTimeOffset startDate, DateTimeOffset endDate) {
            //this.dbConnectionString = new SecretReader().GetSecret(AppEnvironment.TEST);

            MySqlConnection conn = (MySqlConnection)new MySqlConnectionCustom().getConnection();

            DataTable expenseDT = new DataTable();

            try {

                String sqlStatementGetExpenses = @"SELECT exp.name AS Name, et.categoryName AS Type, exp.value AS Value, exp.date AS Date
                                                   FROM expenses exp
                                                   INNER JOIN expense_types et ON exp.type = et.categoryID
                                                   WHERE exp.date BETWEEN @startDate AND @endDate";
                
                MySqlCommand getExpensesCommand = new MySqlCommand(sqlStatementGetExpenses);
                getExpensesCommand.Parameters.AddWithValue("@startDate", startDate);
                getExpensesCommand.Parameters.AddWithValue("@endDate", endDate);
                getExpensesCommand.Connection = conn;

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getExpensesCommand);

                conn.Open();
                dataAdapter.Fill(expenseDT);

            } catch (MySqlException ex) {
                Debug.WriteLine(ex.Message);
            } finally {
                conn.Close();
            }

            return expenseDT;
        }

        public DataTable GetCategoriesPercentage(int month, int year) {
            throw new NotImplementedException();
        }

        public DataTable GetMonthlyEvolution(int year) {
            throw new NotImplementedException();
        }
    }
}
