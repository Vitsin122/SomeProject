using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SomeProject.Model
{
    public class FuncArgs : INotifyPropertyChanged
    {
        private int _x;
        public int X
        {
            get => _x;
            set
            {
                _x = value;
                OnPropertyChanged("X");            
            }
        }
        private int _y;
        public int Y
        {
            get => _y;
            set
            {
                _y = value;
                OnPropertyChanged("Y");
            }
        }
        private double _result;
        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
