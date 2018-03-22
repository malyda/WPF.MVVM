using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;

namespace WPF.MVVM.AllInOne
{
    internal class AllInOnePageViewModel : INotifyPropertyChanged
    {
        private int _numberOfClicks;

        public AllInOnePageViewModel()
        {
            DisplayMessageCommand = new RelayCommand(ClickMethod);
            var persons = new List<Person>();
            for (var i = 0; i < 100; i++) persons.Add(new Person("name" + i, i));
            Persons = new ObservableCollection<Person>(persons);
        }

        public int NumberOfClicks
        {
            get => _numberOfClicks;
            set
            {
                _numberOfClicks = value;
                OnPropertyChanged("NumberOfClicks");
            }
        }

        public string PersonName { get; set; } = "jméno osoby";

        // MVVMLight nugget
        public ObservableCollection<Person> Persons { get; set; }

        public RelayCommand DisplayMessageCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void ClickMethod()
        {
            NumberOfClicks++;
        }

        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(name));
        }
    }
}