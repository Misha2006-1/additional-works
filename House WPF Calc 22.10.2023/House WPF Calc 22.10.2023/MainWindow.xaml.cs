using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace House_WPF_Calc_22._10._2023
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Mainroot.Children)
            {
                if (el is Button) 
                { 
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        private void Button_Click (object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "AC")
            Output.Text = string.Empty;
                 else
            { 
                if (str == "=")
                {
                    string value= new DataTable().Compute (Output.Text,null).ToString ();
                    Output.Text = value;
                }
                else
            Output.Text += str;
            }
        }

    }   
        


}
