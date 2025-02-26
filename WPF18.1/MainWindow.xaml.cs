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

namespace WPF18._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation buttonAnimation = new DoubleAnimation
            {
                From = helloButton.ActualWidth,
                //изменение ширины кнопки от текущего значения до 150 пикселей
                To = 150,
                AutoReverse = true,
                //повтор анимации
                RepeatBehavior = new RepeatBehavior(5),
                Duration = TimeSpan.FromSeconds(3)
            };
            //плавное изменение свойства в обратную сторону
            buttonAnimation.RepeatBehavior = new RepeatBehavior(2);
            //Запуск анимации
            helloButton.BeginAnimation(Button.WidthProperty, buttonAnimation);
        }
    }
}
