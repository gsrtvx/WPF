using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF14._7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly PersonModel Tom;
        public MainWindow()
        {
            InitializeComponent();
            Tom = new PersonModel();
            this.DataContext = Tom;
        }
    public class PersonModel
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Position { get; set; }
        }
    }
}
