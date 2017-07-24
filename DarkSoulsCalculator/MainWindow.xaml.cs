using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace DarkSoulsCalculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            SetD2MultiBinding();
        }

        private void SetD2MultiBinding()
        {
            // 准备基本 Binding
            var b1 = new Binding() { Source = TbDark2A.Text };
            var b2 = new Binding() { Source = TbDark2B.Text };

            // 准备 MultiBinding
            var mb = new MultiBinding
            {
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger= UpdateSourceTrigger.PropertyChanged
            };
            mb.Bindings.Add(b1);
            mb.Bindings.Add(b2);

            // 设定值转换器
            mb.Converter = new DarkSoul2Convert();

            // 将 ListBox 与 MultiBinding 对象相关联
            LbDark2.SetBinding(ItemsControl.ItemsSourceProperty, mb);
        }

        private void TbDark2A_KeyUp(object sender, KeyEventArgs e)
        {
            // 每进行一次输入必须重新绑定，否则 ListBox 不会刷新
            ReSetBinding();
        }

        private void TbDark2B_KeyUp(object sender, KeyEventArgs e)
        {
            ReSetBinding();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var temp = TbDark2A.Text;
            TbDark2A.Text = TbDark2B.Text;
            TbDark2B.Text = temp;
            ReSetBinding();
        }

        private void ReSetBinding()
        {
            BindingOperations.ClearAllBindings(LbDark2);
            SetD2MultiBinding();
        }
    }
}
