using System.Windows.Controls;

namespace WPF.MVVM.SimpleBinding
{
    /// <summary>
    ///     Interaction logic for AllInOnePage.xaml
    /// </summary>
    public partial class SimpleBinding : Page
    {
        public SimpleBinding()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string BoundText { get; } = "Some bound text";
        public int BoundNumber { get; } = 10;
    }
}