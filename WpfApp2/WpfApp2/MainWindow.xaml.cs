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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            OkButton.Content = "Ok";
//            Name1.Content = "Name1";
            OkButton.Click += OkButton_Click; ;
            Name3.Click += Name3_Click;
            
        }

        private void Name3_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if ((String)b.Content == "Changed")
            {
                b.Content = "Ok";
            } else {
                b.Content = "Changed";
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Window1();
            w.ShowDialog();
        }
    }
}
