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
    /// Logika interakcji dla klasy Zadanie3i4.xaml
    /// </summary>
    public partial class Zadanie3i4 : Window
    {
        public List<Student> studenci = new List<Student>();

        private Student forDeletion = null;

        public Zadanie3i4()
        {
            InitializeComponent();

            //Dane studentow
            studenci.Add(new Student { FirstName = "Jan", LastName = "Kowalski", IndexNumber = "s1234" });
            studenci.Add(new Student { FirstName = "Mariusz", LastName = "Kowalski", IndexNumber = "s1234" });
            studenci.Add(new Student { FirstName = "Andrzej", LastName = "Kowalski", IndexNumber = "s1234" });

            StudentsDataGrid.ItemsSource = studenci;

        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            String imie = Imie.Text;
            String nazwisko = Nazwisko.Text;
            String index = NrIndeksu.Text;

            Student student = new Student { FirstName = imie, LastName = nazwisko, IndexNumber = index };

            studenci.Add(student);

            StudentsDataGrid.ItemsSource = null;
            StudentsDataGrid.ItemsSource = studenci;
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            if (null == forDeletion)
            {
                return;
            }

            studenci.Remove(forDeletion);

            StudentsDataGrid.ItemsSource = null;
            StudentsDataGrid.ItemsSource = studenci;
        }

        private void StudentsDataGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid) sender;
            Student x = (Student) dg.SelectedItem;
            if (null == x)
            {
                return;
            }

            Imie.Text = x.FirstName;
            Nazwisko.Text = x.LastName;
            NrIndeksu.Text = x.IndexNumber;

            forDeletion = x;
        }

        private void StudentsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            Student selected = (Student)dg.SelectedItem;
            Window edit = new StudentEditDialog(selected);

            edit.ShowDialog();
        }
    }
}
