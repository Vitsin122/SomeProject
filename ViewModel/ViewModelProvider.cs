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
        private ObservableCollection<int> cList = new ObservableCollection<int>() {1,2,3,4,5};
        public ObservableCollection<int> CList
        {
            get => cList;
            set
            {
                cList = value;
                OnPropertyChanged("CList");
            }
        }

        public TextBlock? SelectedRB
        {
            get => _textBlockAdapter!.TextBlock;
            set
            {
                _textBlockAdapter!.TextBlock = value;
                OnPropertyChanged("SelectedRB");


                //I don't know why after rebuild cList combobox does not exist
                //And this solution just a temporary crutch
                if (value!.Text == "Линейная")
                {
                    cList[0] = 1;
                    cList[1] = 2;
                    cList[2] = 3;
                    cList[3] = 4;
                    cList[4] = 5;
                }
                else if (value!.Text == "Квадратичная")
                {
                    cList[0] = 10;
                    cList[1] = 20;
                    cList[2] = 30;
                    cList[3] = 40;
                    cList[4] = 50;
                }
                else if (value!.Text == "Кубическая")
                {
                    cList[0] = 100;
                    cList[1] = 200;
                    cList[2] = 300;
                    cList[3] = 400;
                    cList[4] = 500;
                }
                else if (value!.Text == "4-ой степени")
                {
                    cList[0] = 1000;
                    cList[1] = 2000;
                    cList[2] = 3000;
                    cList[3] = 4000;
                    cList[4] = 5000;
                }
                else if (value!.Text == "5-ой степени")
                {
                    cList[0] = 10000;
                    cList[1] = 20000;
                    cList[2] = 30000;
                    cList[3] = 40000;
                    cList[4] = 50000;
                }
            }
        }
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;
        public int C { get; set; } = 1;

        public ObservableCollection<IFunction> functions { get; set; } = new ObservableCollection<IFunction>();

        public ObservableCollection<FuncArgs> FuncArgs { get; set; } = new ObservableCollection<FuncArgs>();












        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
