using System.Windows.Controls;

namespace WPF.MVVM.AllInOne
{
    /// <summary>
    ///     Interaction logic for AllInOnePage.xaml
    /// </summary>
    public partial class AllInOnePage : Page
    {
        public AllInOnePage()
        {
            InitializeComponent();
            DataContext = new AllInOnePageViewModel();
        }
    }
}