using Cwiczenia4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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

namespace Cwiczenia4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> ListaStudentow;

        public MainWindow()
        {
            InitializeComponent();

            ListaStudentow = new ObservableCollection<Student>();

            ConnectToDatabase();

            // LoadDataToListBox1();
            LoadDataToListBoxAndDataGrid2();
            ListaStudentow.CollectionChanged += ListaStudentow_CollectionChanged;
        }

        private void ConnectToDatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\workspace\\apbd\\Cwiczenia4\\Cwiczenia4\\Database1.mdf;Integrated Security=True");
            SqlCommand com = new SqlCommand("select * from emp", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                int id = (int) dr["empno"];
                string ename = dr["ename"].ToString();
                ListaStudentow.Add(new Student { Nazwisko = ename, IdStudent = id });
            }

            con.Dispose();
        }

        private void ListaStudentow_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //MessageBox.Show("Kolekcja zmieniła się");
        }

        private void LoadDataToListBox1()
        {
            StudentsListBox.Items.Add(new ListBoxItem { Content = "Kwiatkowska" });
            StudentsListBox.Items.Add("Wieczorkowski");
            StudentsListBox.Items.Add(new Student { IdStudent = 1, Imie = "Mariusz", Nazwisko = "Kwiatkowski" });
        }

        private void LoadDataToListBoxAndDataGrid2()
        {
            
            ListaStudentow.Add(new Student { IdStudent = 1, Imie = "Jan", Nazwisko = "Kowalski", Plec = true });
            ListaStudentow.Add(new Student { IdStudent = 2, Imie = "Mariusz", Nazwisko = "Głowacki" });

            StudentsListBox.ItemsSource = ListaStudentow;
            StudentsDataGrid.ItemsSource = ListaStudentow;
        }

        private void ShowSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(StudentsListBox.SelectedItem.ToString());
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            ListaStudentow.Add(new Student { IdStudent = 3, Imie = "AAA", Nazwisko = "BBB" });
        }
    }
}
