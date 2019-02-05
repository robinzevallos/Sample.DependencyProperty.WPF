namespace Sample.Traditional
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class DemoControl : UserControl
    {
        public static readonly DependencyProperty TextProperty
            = DependencyProperty.Register(
                "Text",
                typeof(String),
                typeof(DemoControl));

        public String Text
        {
            get => (String)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextTagProperty 
            = DependencyProperty.Register(
                "TextTag",
                typeof(String), 
                typeof(DemoControl));

        public String TextTag
        {
            get => (String)GetValue(TextTagProperty);
            set => SetValue(TextTagProperty, value);
        }

        public static readonly DependencyProperty ForegroundTagProperty
            = DependencyProperty.Register(
                "ForegroundTag", 
                typeof(Brush),
                typeof(DemoControl));

        public Brush ForegroundTag
        {
            get => (Brush)GetValue(ForegroundTagProperty);
            set => SetValue(ForegroundTagProperty, value);
        }

        public DemoControl()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
