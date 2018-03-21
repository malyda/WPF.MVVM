using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace WPF.MVVM.MvvmlightCommand
{
    internal class MvvmlightCommandViewModel : INotifyPropertyChanged
    {
        private int _numberOfClicks;

        public MvvmlightCommandViewModel()
        {
            ClickCommand = new RelayCommand(ClickMethod);

            CommandWithParameters = new RelayCommand<Person>(CommandWithParametersMethod);
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

        
        public ObservableCollection<Person> Persons { get; set; }
        
        // MVVMLight nugget
        public RelayCommand ClickCommand { get; }

        public RelayCommand<Person> CommandWithParameters { get; }
        public Person PersonToBind { get; set; } = new Person("Jméno a přijmení", 1);

        public event PropertyChangedEventHandler PropertyChanged;

        private void ClickMethod()
        {
            NumberOfClicks++;
        }

        private void CommandWithParametersMethod(Person person)
        {
            MessageBox.Show($"Person name: {person.Name} id: {person.Id}");
        }

        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
    }
}