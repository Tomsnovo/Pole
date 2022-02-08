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

namespace Pole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //int a;
        //int b;
        
        int[] pole = new int[100];
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            //a = random.Next(1,100);
            //b = random.Next(1, 100);
            //txtvypis.Text = a.ToString() + "; " + b.ToString();
            
            //vypsani prvku pole do string 
            txtvypis.Text = "";
            for (int i = 0; i < pole.Length; i++)
            {
                txtvypis.Text += pole[i].ToString() + "; ";            
            }

            //enter
            txtvypis.Text += "\r\n";
            txtvypis.Text += "\r\n";

            //jiny zpusob vypsani pole do stringu
            txtvypis.Text += string.Join("; ", pole);

        }
    }
}
