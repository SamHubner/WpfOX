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

namespace WpfOX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Position1_Click(object sender, RoutedEventArgs e)
        {
            if (Position1.Content == "X")
            {
                Position1.Content = "O";
            }
            else
            {
                Position1.Content = "X";
            }

        }

        private void Position2_Click(object sender, RoutedEventArgs e)
        {
            if (Position2.Content == "X")
            {
                Position2.Content = "O";
            }
            else
            {
                Position2.Content = "X";
            }

        }

        private void Position3_Click(object sender, RoutedEventArgs e)
        {
            if (Position3.Content == "X")
            {
                Position3.Content = "O";
            }
            else
            {
                Position3.Content = "X";
            }

        }

        private void Position4_Click(object sender, RoutedEventArgs e)
        {
            if (Position4.Content == "X")
            {
                Position4.Content = "O";
            }
            else
            {
                Position4.Content = "X";
            }
        }

        private void Position5_Click(object sender, RoutedEventArgs e)
        {
            if (Position5.Content == "X")
            {
                Position5.Content = "O";
            }
            else
            {
                Position5.Content = "X";
            }
        }

        private void Position6_Click(object sender, RoutedEventArgs e)
        {
            if (Position6.Content == "X")
            {
                Position6.Content = "O";
            }
            else
            {
                Position6.Content = "X";
            }
        }

        private void Position7_Click(object sender, RoutedEventArgs e)
        {
            if (Position7.Content == "X")
            {
                Position7.Content = "O";
            }
            else
            {
                Position7.Content = "X";
            }
        }

        private void Position8_Click(object sender, RoutedEventArgs e)
        {
            if (Position8.Content == "X")
            {
                Position8.Content = "O";
            }
            else
            {
                Position8.Content = "X";
            }
        }

        private void Position9_Click(object sender, RoutedEventArgs e)
        {
            if (Position9.Content == "X")
            {
                Position9.Content = "O";
            }
            else
            {
                Position9.Content = "X";
            }
        }
    }
}
