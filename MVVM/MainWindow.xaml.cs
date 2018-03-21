using System;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;
using WPF.MVVM.AllInOne;

namespace WPF.MVVM
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RelayCommand<Uri> NavigateCommand { get; private set; }

        public Uri SimpleBindingUri { get; set; } = new Uri("SimpleBinding/SimpleBinding.xaml", UriKind.Relative);
        public Uri BindingWithViewModelUri { get; set; } = new Uri("BindingWithViewModel/BindingWithViewModel.xaml", UriKind.Relative);
        public Uri MvvmlightCommandUri { get; set; } = new Uri("MvvmlightCommand/MvvmlightCommand.xaml", UriKind.Relative);

        public Uri AllInOnePageURI { get; set; } = new Uri("AllInOne/AllInOnePage.xaml", UriKind.Relative);
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            NavigateCommand = new RelayCommand<Uri>(NavigateTo);
        }

        private void NavigateTo(Uri navigatToPage)
        {
            NavigationFrame.NavigationService.Navigate(navigatToPage);
        }
    
    }
}
