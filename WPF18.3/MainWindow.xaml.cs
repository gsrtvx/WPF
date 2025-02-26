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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF18._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // анимация для ширины
            DoubleAnimation widthAnimation = new DoubleAnimation
            {
                From = helloButton.ActualWidth,
                To = 150,
                Duration = TimeSpan.FromSeconds(5)
            };

            // анимация для высоты
            DoubleAnimation heightAnimation = new DoubleAnimation
            {
                From = helloButton.ActualHeight,
                To = 60,
                Duration = TimeSpan.FromSeconds(5)
            };

            helloButton.BeginAnimation(Button.WidthProperty, widthAnimation);
            helloButton.BeginAnimation(Button.HeightProperty, heightAnimation);
        }
    }
}
