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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox c = (ComboBox) sender;
            try
            {
                ComboBoxItem item = (ComboBoxItem) c.SelectedItem;
                object value = item.Content;
                if (null != value) {
                    TextBox1.Text = value.ToString();
                }
            } catch (InvalidOperationException ex)
            {
                Console.Out.WriteAsync(ex.ToString());
            } catch (ArgumentException ex)
            {
                Console.Out.WriteAsync(ex.ToString());
            }

}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
