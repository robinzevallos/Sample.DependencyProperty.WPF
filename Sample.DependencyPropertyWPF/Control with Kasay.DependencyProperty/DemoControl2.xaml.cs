namespace Sample.DependencyPropertyWPF
{
    using Kasay.DependencyProperty.WPF;
    using System;
    using System.Windows.Controls;
    using System.Windows.Media;

    [AutoDependencyProperty]
    public partial class DemoControl2 : UserControl
    {
        public String TextTag { get; set; }

        public Brush ForegroundTag { get; set; }

        public DemoControl2()
        {
            InitializeComponent();
        }
    }
}
