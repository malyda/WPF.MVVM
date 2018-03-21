using System.Windows.Controls;

namespace WPF.MVVM.MvvmlightCommand
{
    /// <summary>
    ///     Interaction logic for AllInOnePage.xaml
    /// </summary>
    public partial class MvvmlightCommand : Page
    {
        public MvvmlightCommand()
        {
            InitializeComponent();
            DataContext = new MvvmlightCommandViewModel();
        }
    }
}