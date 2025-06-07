using System.Collections.ObjectModel;
using System.Data;
using WinUI3DemoCore.model;

namespace WinUI3DemoCore.view_model {
    public interface IBudgetItemViewModel {
        public ObservableCollection<DataPoint> Series { get; set; } //Remove after fully implementing the dpendency injection system

        DataTable GetItemList(DateTimeOffset startDate, DateTimeOffset endDate);

        DataTable GetCategoriesPercentage(int month, int year);

        DataTable GetMonthlyEvolution(int year);
    }
}
