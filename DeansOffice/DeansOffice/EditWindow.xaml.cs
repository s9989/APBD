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
    public partial class EditWindow : Window
    {
        public Student CurrentStudent { get; set; }
        ObservableCollection<Study> studies;

        public EditWindow()
        {
            InitializeComponent();
            CurrentStudent = new Student();

            InitializeData();
            StudyComboBox.ItemsSource = studies;
        }

        private void InitializeData()
        {
            var DbProvider = new StudentsDbService();
            studies = new ObservableCollection<Study>(DbProvider.AllStudies());
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var DbProvider = new StudentsDbService();
            CurrentStudent.IdStudent = DbProvider.AddStudent(CurrentStudent);
            //MessageBox.Show(CurrentStudent.IdStudent.ToString());
            Close();
        }

        public void InsertStudent(Student student)
        {
            CurrentStudent = student;
            UpdateStudent();
        }

        private void UpdateStudent()
        {
            CurrentStudent.FirstName = FirstNameInput.Text;
            CurrentStudent.LastName = LastNameInput.Text;
            CurrentStudent.IndexNumber = IndexNumberInput.Text;
            CurrentStudent.Study = (Study) StudyComboBox.SelectedItem;
        }

        private void Text_Changed(object sender, TextChangedEventArgs e)
        {
            UpdateStudent();
        }

        private void Selection_Changed(object sender, SelectionChangedEventArgs e)
        {
            UpdateStudent();
        }
    }
}
