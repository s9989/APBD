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
    /// Logika interakcji dla klasy StudentEditDialog.xaml
    /// </summary>
    public partial class StudentEditDialog : Window
    {
        public StudentEditDialog(Student student)
        {
            InitializeComponent();

            if (null == student)
            {
                return;
            }

            Imie.Text = student.FirstName;
            Nazwisko.Text = student.LastName;
            NrIndeksu.Text = student.IndexNumber;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
