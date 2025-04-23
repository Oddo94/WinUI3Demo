using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.Kernel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUI3DemoCore;
using WinUI3DemoCore.model;
using System.Collections;
using LiveChartsCore.Kernel.Sketches;
using System.Drawing;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI3Demo.model.request;

namespace WinUI3Demo {
    public partial class LiveChartsViewModelWrapper : ObservableObject {
        [ObservableProperty]
        private ObservableCollection<ICartesianAxis> xAxis =  new ();

        [ObservableProperty]
        private ObservableCollection<ISeries> series;

        [ObservableProperty]
        private DateTimeOffset expenseStartDate;

        [ObservableProperty]
        private DateTimeOffset expenseEndDate;

        [ObservableProperty]
        private DateTimeOffset chartDate;

        private BudgetSummaryViewModel budgetSummaryViewModel;


        public LiveChartsViewModelWrapper(BudgetSummaryViewModel budgetSummaryViewModel) {

            this.budgetSummaryViewModel = budgetSummaryViewModel;
            //Axis xAxis = new Axis();
            Axis yAxis = new Axis();
            this.expenseStartDate = DateTimeOffset.Now;
            this.expenseEndDate = DateTimeOffset.Now;
            this.chartDate = DateTimeOffset.Now;


            xAxis = new ObservableCollection<ICartesianAxis>() {
                    new Axis() {
                        Labels = budgetSummaryViewModel
                     .Series
                     .ToList()
                     .Select(dataPoint => dataPoint.Name.ToString())
                     .ToArray()
                    }
            };




            List<double> values = new List<double>();
            foreach (DataPoint currentPoint in budgetSummaryViewModel.Series) {
                //if (currentPoint != null) {
                //    xAxis.Labels.Add(currentPoint.Name);
                //} else {
                //    xAxis.Labels.Add("Error");
                //}

                values.Add(currentPoint.Value);
            }

            //ColumnSeries<double> columnSeries = new ColumnSeries<double>(values.ToArray());
            //series = new ColumnSeries<double>();

            series = new ObservableCollection<ISeries> {
                new ColumnSeries<double>(
                   values: values.ToArray()
            )
        };
       }

            [RelayCommand]
            public void ChangeChartData() {


           //switch(yearlyDataRequest.Year) {
           //    case 2025:
           //         seriesList = new List<double>() { 2000, 1900, 1800, 1700, 1600, 1500, 1400, 1300, 1200, 1100, 1000, 900 };
           //         break;
           //     case 2024:
           //         seriesList = new List<double>() { 100, 200, 300, 400 , 500, 600, 700, 800, 900, 1000, 1200 };
           //         break;

           //     case 2023:
           //         seriesList = new List<double>() { 1000, 1100, 1200, 1300, 1400, 1500, 1700,  1400, 1300, 1200, 1100, 1000  };
           //         break;

           //     default:
           //         seriesList = new List<double>() { 100, 200, 200, 100, 300, 300, 200, 400, 400, 300, 500, 500 };
           //         break;
           // }

            budgetSummaryViewModel.updateData(3, chartDate.Year);


           List<double> seriesList = budgetSummaryViewModel
                .Series
                .ToList()
                .Select(dataPoint => dataPoint.Value)
                .ToList();

            this.Series.Clear();
                this.Series.Add(new ColumnSeries<double>(values: seriesList.ToArray()));
            }
        }
    }
