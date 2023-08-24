using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SomeProject.Model
{
    public class TextBlockAdapter : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void Dispose() { }

        private TextBlock? _textBlock = null;
        public TextBlock? TextBlock
        {
            get => _textBlock;
            set
            {
                _textBlock = value;
                OnPropertyChanged("TextBlock");
            }
        }
    }
}
