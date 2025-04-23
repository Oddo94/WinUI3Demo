using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUI3Demo.model.request;

namespace WinUI3Demo.utils.converters {
    internal class YearlyDataRequestConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value is DatePicker) {
                int selectedYear = ((DatePicker)value).Date.Year;
                int userId;
                bool canConvert = Int32.TryParse(parameter.ToString(), out userId);

                if (canConvert) {
                    return new YearlyDataRequest(userId, selectedYear);
                } else {
                    return new YearlyDataRequest(0, selectedYear);
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
