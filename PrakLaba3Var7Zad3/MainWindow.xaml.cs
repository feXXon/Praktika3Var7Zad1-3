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

namespace PrakLaba3Var7Zad3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = int.Parse(txt3.Text);
            if (a > b && b > c)
            {
                txt4.Text = ($"{a},{b},{c}");
            }
            else
                if (c > b && b > a)
            {
                txt4.Text = ($"{a},{b},{c}");
            }
            else
                if(b > a && a > c)
            {
                txt4.Text = ($"{c},{a},{b}");
            }
            else
               if (c > a && a > b)
            {
                txt4.Text = ($"{b},{a},{c}");
            }
            else
                if (a > c && c > b)
            {
                txt4.Text = ($"{b},{c},{a}");
            }
            else
                if (b > c && c > a)
            {
                txt4.Text = ($"{a},{c},{b}");
            }
        }
    }
}
