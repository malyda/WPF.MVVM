using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WPF.MVVM.BindingWithViewModel
{
    internal class BindingWithViewModelViewModel
    {
        public BindingWithViewModelViewModel()
        {
            var persons = new List<Person>();
            for (var i = 0; i < 100; i++)
                persons.Add(new Person("name" + i, i));
            Persons = new ObservableCollection<Person>(persons);
        }

        public string BoundText { get; } = "Some bound text";
        public int BoundNumber { get; } = 10;

        public ObservableCollection<Person> Persons { get; set; }
    }
}