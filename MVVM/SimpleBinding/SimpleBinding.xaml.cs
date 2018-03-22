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
            // Nastavení pro View, které udává cestu, kde má View hledat zadaná přístupová rozhraní
            DataContext = this;
        }

        /// <summary>
        ///     View je napojeno na veřejné přístupové rozhraní dat
        /// </summary>
        public string BoundText { get; } = "Some bound text";

        public int BoundNumber { get; } = 10;
    }
}