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

namespace PrakLaba3Var7Zad1
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
            int S = a + b;
            if (S % 2 != 0)
            {
                txt3.Text = ($"Ялвляется нечётным");
            }
            else
            {
                txt3.Text = ($"Является чётным");
            }
        }
    }
}
