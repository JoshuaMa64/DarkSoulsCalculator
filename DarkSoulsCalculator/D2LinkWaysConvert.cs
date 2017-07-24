using System;
using System.Globalization;
using System.Windows.Data;

namespace DarkSoulsCalculator
{
    public class D2LinkWaysConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var t = value.ToString();
                switch (t)
                {
                    case "白标记蜡石":
                        return "互助";
                    case "白标记蜡石 + 刻名戒指":
                        return "互助";
                    case "白标记小蜡石":
                        return "互助";
                    case "白标记小蜡石 + 刻名戒指":
                        return "互助";
                    case "龟裂血红眼眸宝珠":
                        return "入侵";
                    case "龟裂深蓝眼眸宝珠":
                        return "入侵";
                    case "红标记蜡石":
                        return "入侵";
                    case "古龙眼珠":
                        return "入侵";
                    case "鼠王誓约":
                        return "入侵";
                    case "钟卫誓约":
                        return "入侵";
                    case "青之守护者的救援召唤":
                        return "互助";
                    case "青之守护者的试炼":
                        return "决斗";
                    default:
                        return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}