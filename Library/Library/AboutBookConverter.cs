using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace Library
{
    public class AboutBookConverter:IValueConverter
    {
        public Object Convert(Object value,Type TargetType, Object parameter, CultureInfo culture)
        {
            return null;
        }
        public Object ConvertBack(Object value, Type TargetType, Object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
