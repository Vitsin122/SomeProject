using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SomeProject.View;
using SomeProject.Model;
using System.Collections.ObjectModel;
using SomeProject.Model.Functions;

namespace SomeProject.ViewModel
{
    public class ViewModelProvider : INotifyPropertyChanged
    {
        private TextBlockAdapter? _textBlockAdapter = new TextBlockAdapter();
        public TextBlock? SelectedRB
        {
            get => _textBlockAdapter!.TextBlock;
            set
            {
                _textBlockAdapter!.TextBlock = value;
                OnPropertyChanged("SelectedRB");            }
        }
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;

        public ObservableCollection<IFunction> functions { get; set; } = new ObservableCollection<IFunction>();

        public ObservableCollection<FuncArgs> FuncArgs { get; set; } = new ObservableCollection<FuncArgs>();












        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
