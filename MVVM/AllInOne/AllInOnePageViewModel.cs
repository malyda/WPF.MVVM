using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;

namespace WPF.MVVM.AllInOne
{
    class AllInOnePageViewModel : INotifyPropertyChanged
    {
        private int _numberOfClicks;
        public int NumberOfClicks
        {
            get
            {
                return _numberOfClicks;
            }
            set
            {
                _numberOfClicks = value;
                OnPropertyChanged("NumberOfClicks");
            }
        }

        public string PersonName { get; set; } = "jméno osoby";

        // MVVMLight nugget
        public ObservableCollection<Person> Persons { get; set; }

        public RelayCommand DisplayMessageCommand { get; private set; }

        public AllInOnePageViewModel()
        {
            DisplayMessageCommand = new RelayCommand(ClickMethod,false);
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 100; i++)
            {
                persons.Add(new Person("name"+i,i));
            }
            Persons = new ObservableCollection<Person>( persons);
            
        }

        private void ClickMethod()
        {
            NumberOfClicks++;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
