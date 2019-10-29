using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DarkHeresy2CharacterCreator.ViewModel.Converters
{
    public class ArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            StringBuilder temp = new StringBuilder();
            string result;
            foreach (var item in value as ObservableCollection<object>)
                temp.Append(item.ToString()).Append(", ");
            result = temp.ToString().Substring(0, temp.Length - 2);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
