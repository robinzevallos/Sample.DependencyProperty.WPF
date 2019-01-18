using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sample.DependencyProperty.WPF
{
    /// <summary>
    /// Interaction logic for DemoControl1.xaml
    /// </summary>
    public partial class DemoControl1 : UserControl
    {

        // Using a DependencyProperty as the backing store for TextTag.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextTagProperty =
            DependencyProperty.Register("TextTag", typeof(String), typeof(DemoControl1), new PropertyMetadata(0));

        public String TextTag
        {
            get => (String)GetValue(TextTagProperty);
            set => SetValue(TextTagProperty, value);
        }

        public DemoControl1()
        {
            InitializeComponent();

            ((FrameworkElement)Content).DataContext = this;
        }
    }
}
