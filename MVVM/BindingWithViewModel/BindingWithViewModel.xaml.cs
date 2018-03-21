using System.Windows.Controls;

namespace WPF.MVVM.BindingWithViewModel
{
    /// <summary>
    ///     Interaction logic for AllInOnePage.xaml
    /// </summary>
    public partial class BindingWithViewModel : Page
    {
        public BindingWithViewModel()
        {
            InitializeComponent();
            DataContext = new BindingWithViewModelViewModel();
        }
    }
}