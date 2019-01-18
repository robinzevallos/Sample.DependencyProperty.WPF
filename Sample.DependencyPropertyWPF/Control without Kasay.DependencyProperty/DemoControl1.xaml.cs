namespace Sample.DependencyPropertyWPF
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class DemoControl1 : UserControl
    {
        public static readonly DependencyProperty TextTagProperty =
            DependencyProperty.Register(
                "TextTag",
                typeof(String), 
                typeof(DemoControl1), 
                null);

        public String TextTag
        {
            get => (String)GetValue(TextTagProperty);
            set => SetValue(TextTagProperty, value);
        }

        public static readonly DependencyProperty ForegroundTagProperty =
            DependencyProperty.Register(
                "ForegroundTag", 
                typeof(Brush),
                typeof(DemoControl1),
                null);

        public Brush ForegroundTag
        {
            get => (Brush)GetValue(ForegroundTagProperty);
            set => SetValue(ForegroundTagProperty, value);
        }

        public DemoControl1()
        {
            InitializeComponent();

            ((FrameworkElement)Content).DataContext = this;
        }
    }
}
