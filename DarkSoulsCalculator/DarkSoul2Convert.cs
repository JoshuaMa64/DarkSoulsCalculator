using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace DarkSoulsCalculator
{
    class DarkSoul2Convert : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var linkWays = new List<string>();
                var levels = new List<int>()
                {
                    int.Parse(values[0].ToString()),
                    int.Parse(values[1].ToString())
                }
                .Select(DarkSoul2.SmToLevel).ToList();

                #region AddLinkWays

                var i = DarkSoul2.WhiteSignSoapstone(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("白标记蜡石");
                }

                i = DarkSoul2.WhiteSignSoapstoneWithName(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("白标记蜡石 + 刻名戒指");
                }

                i = DarkSoul2.SmallWhiteSignSoapstone(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("白标记小蜡石");
                }

                i = DarkSoul2.SmallWhiteSignSoapstoneWithName(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("白标记小蜡石 + 刻名戒指");
                }

                i = DarkSoul2.RedSignSoapstone(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("红标记蜡石");
                }

                i = DarkSoul2.RedEyeOrb(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("龟裂血红眼眸宝珠");
                }

                i = DarkSoul2.BlueEyeOrb(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("龟裂深蓝眼眸宝珠");
                }

                i = DarkSoul2.DragonEye(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("古龙眼珠");
                }

                i = DarkSoul2.Clangorours(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("钟卫誓约");
                }

                i = DarkSoul2.Grawing(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("鼠王誓约");
                }

                i = DarkSoul2.Protector(levels[0]);
                if (i[0] <= levels[1] && levels[1] <= i[1])
                {
                    linkWays.Add("青之守护者的试炼");
                }

                linkWays.Add("青之守护者的救援召唤");

                #endregion

                return linkWays;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
