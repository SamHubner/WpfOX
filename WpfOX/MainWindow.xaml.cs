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
        static int count = 1;
        OnX g = new OnX();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Position1_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(0);
            if (result == true) updateGUI();
        }

        private void Position2_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(1);
            if (result == true) updateGUI();
        }

        private void Position3_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(2);
            if (result == true) updateGUI();
        }

        private void Position4_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(3);
            if (result == true) updateGUI();
        }

        private void Position5_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(4);
            if (result == true) updateGUI();
        }

        private void Position6_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(5);
            if (result == true) updateGUI();
        }

        private void Position7_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(6);
            if (result == true) updateGUI();
        }

        private void Position8_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(7);
            if (result == true) updateGUI();
        }

        private void Position9_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(8);
            if (result == true) updateGUI();
        }

        private void Turn_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (count == 1)
            {
                Turn.Text = "O";
            }
            else
            {
                Turn.Text = "X";
            }
        }
        private void updateGUI()
        {
            Button[] bs = { Position1, Position2, Position3, Position4, Position5, Position6, Position7, Position8, Position9 };
            Board b = g.getBoard();
            int[] elementsBoard = b.getBoard();
            //insert turn update here

            for (int x = 0; x < elementsBoard.Length; x++)
            {
                if (elementsBoard[x] == 0) bs[x].Content = " ";
                if (elementsBoard[x] == 1) bs[x].Content = "O";
                if (elementsBoard[x] == 2) bs[x].Content = "X";
            }
            

        }

        private void Position10_Click(object sender, RoutedEventArgs e)
        {
            Board b = g.getBoard();
            int[] elementsBoard = b.getBoard();
            Button[] bs = { Position1, Position2, Position3, Position4, Position5, Position6, Position7, Position8, Position9 };
            for (int x = 0; x < elementsBoard.Length; x++)
            {
                if (elementsBoard[x] == 0) elementsBoard[x] = 0;
                if (elementsBoard[x] == 1) elementsBoard[x] = 0;
                if (elementsBoard[x] == 2) elementsBoard[x] = 0;
            }
            updateGUI();
        }

        private void Position11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Position12_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
