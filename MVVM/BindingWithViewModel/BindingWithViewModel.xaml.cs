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
            // Nastevení pro View, která udává cestu, kde má hledat zdroje pro Binding
            // Zdrojem je ViewModel, který slouží jako vrstva mezi View a Modelem (bussiness logikou) aplikace
            DataContext = new BindingWithViewModelViewModel();
        }
    }
}