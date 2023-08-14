using System.Windows;
using SomeProject.View.Converters;

namespace SomeProject.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new SomeProject.ViewModel.ViewModelProvider();
        }
    }
}
