namespace Sample
{
    using Kasay;
    using System;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class DemoControl : UserControl
    {
        [Bind] public String Text { get; set; }

        [Bind] public String TextTag { get; set; }

        [Bind] public Brush ForegroundTag { get; set; }

        public DemoControl()
        {
            InitializeComponent();
        }
    }
}
