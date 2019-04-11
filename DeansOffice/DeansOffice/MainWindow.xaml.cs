using DeansOffice.DAL;
using DeansOffice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DeansOffice
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> ListaStudentow;

        public MainWindow()
        {
            InitializeComponent();

            InitializeData();
            StudentsDataGrid.ItemsSource = ListaStudentow;

        }

        private void InitializeData()
        {
            var DbProvider = new StudentsDbService();
            ListaStudentow = new ObservableCollection<Student>(DbProvider.AllStudents());
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            List<Student> toRemove = StudentsDataGrid.SelectedItems.Cast<Student>().ToList();

            foreach (Student student in toRemove)
            {
                ListaStudentow.Remove(student);
            }

            var DbProvider = new StudentsDbService();
            DbProvider.RemoveStudents(toRemove);
        }

        private void StudentsDataGrid_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid dataGrid = (DataGrid)sender;
            SelectedStudentsCount.Content = dataGrid.SelectedItems.Count;
        }
    }
}
