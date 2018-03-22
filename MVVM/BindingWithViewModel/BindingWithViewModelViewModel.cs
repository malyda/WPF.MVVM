using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WPF.MVVM.BindingWithViewModel
{
    internal class BindingWithViewModelViewModel
    {
        /// <summary>
        /// Vytvoří seznam osob, které budou zobrazeny v ListView
        /// </summary>
        public BindingWithViewModelViewModel()
        {
            var persons = new List<Person>();
            for (var i = 0; i < 100; i++)
                persons.Add(new Person("name" + i, i));
            Persons = new ObservableCollection<Person>(persons);
        }

        public string BoundText { get; } = "Some bound text";
        public int BoundNumber { get; } = 10;

        /// <summary>
        /// Veřejné přístupové rozhraní kolekce osob
        /// ListView ho pomocí Binding nastavuje jako svůj ItemsSource a DataContext položek
        /// </summary>
        public ObservableCollection<Person> Persons { get; set; }
    }
}