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

namespace ASP_26_GroceryListChallengeBen
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
        int length;
        int index;
        double[] prices;
        string[] items;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            length = int.Parse(txInput.Text);
            bt1.IsEnabled = false;
            btAdd.IsEnabled = true;
            index = length;
            rlb.Content = "Your Grocery List:";
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            prices = new double[length];
            items = new string[length];
            if ( index > 0)
            {   
                lb1.Content = "Enter List Item #" + (length-index+2);
                prices[length - index] = double.Parse(tb3.Text);
                items[length - index] = tb2.Text;
                rlb.Content += "\n   "+items[length-index]+" - "+prices[length-index];
                index--;
                if (index == 0) {btAdd.IsEnabled = false; lb1.Content = ""; }
            }
            
            tb2.Text = "";
            tb3.Text = "";
            

        }
        private void btReset_Click(object sender, RoutedEventArgs e)
        {
            bt1.IsEnabled = true;
            btAdd.IsEnabled = false;
            rlb.Content = "Your Grocery List:";
            lb1.Content = "Enter List Item #";
            txInput.Text = "";
            tb2.Text = "";
            tb3.Text = "";
        }
    }
}
