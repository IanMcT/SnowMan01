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

namespace SnowMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Width = i * 100+100;
                ellipse.Height = i * 100+100;
                ellipse.Stroke = System.Windows.Media.Brushes.Black;
                ellipse.Fill = System.Windows.Media.Brushes.DarkBlue;
                canvas.Children.Add(ellipse);
                Canvas.SetLeft(ellipse, 100.0 - i*50);
                Canvas.SetTop(ellipse, 50*i*i+50*i);
            }
        }
    }
}
