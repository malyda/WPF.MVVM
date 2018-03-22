using System;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace WPF.MVVM
{
    /// <summary>
    ///     Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            // nastavení Command metody, která se zavolá v rámci Command
            NavigateCommand = new RelayCommand<Uri>(NavigateTo);
        }

        /// <summary>
        ///     Buttony v menu mají nastavený tento Command
        /// </summary>
        public RelayCommand<Uri> NavigateCommand { get; }

        /// <summary>
        ///     Základní uri pro navigaci mezi Page
        /// </summary>
        public Uri SimpleBindingUri { get; set; } = 
            new Uri("SimpleBinding/SimpleBinding.xaml", UriKind.Relative);

        public Uri BindingWithViewModelUri { get; set; } =
            new Uri("BindingWithViewModel/BindingWithViewModel.xaml", UriKind.Relative);

        public Uri MvvmlightCommandUri { get; set; } =
            new Uri("MvvmlightCommand/MvvmlightCommand.xaml", UriKind.Relative);

        public Uri AllInOnePageUri { get; set; } = 
            new Uri("AllInOne/AllInOnePage.xaml", UriKind.Relative);

        /// <summary>
        ///     Navigace v rámci Frame
        /// </summary>
        /// <param name="navigatToPage">Parametr získaný z Button CommandParametr v menu</param>
        private void NavigateTo(Uri navigatToPage)
        {
            NavigationFrame.NavigationService.Navigate(navigatToPage);
        }
    }
}