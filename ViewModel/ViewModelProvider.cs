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

namespace SomeProject.ViewModel
{
    public class ViewModelProvider : INotifyPropertyChanged
    {
        public TextBlock? SelectedRB { get; set; } = null;
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;















        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
