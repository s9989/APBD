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
        public bool editMode = false;
        public Student CurrentStudent { get; set; }
        ObservableCollection<Study> studies;

        public EditWindow(bool edit = false)
        {
            editMode = edit;
            InitializeComponent();
            CurrentStudent = new Student();

            InitializeData();
            if (editMode)
            {
                ConfirmButton.Content = "Zapisz";
            }
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

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var DbProvider = new StudentsDbService();

            if (editMode)
            {
                DbProvider.UpdateStudent(CurrentStudent);
            } else
            {
                CurrentStudent.IdStudent = DbProvider.AddStudent(CurrentStudent);
            }
            
            Close();
        }

        public void InsertStudent(Student student)
        {
            CurrentStudent.IdStudent = student.IdStudent;
            UpdateForm(student);
        }

        private void UpdateForm(Student student)
        {
            FirstNameInput.Text = student.FirstName;
            LastNameInput.Text = student.LastName;
            IndexNumberInput.Text = student.IndexNumber;
            foreach (Study item in StudyComboBox.Items)
            {
                if (((Study)item).IdStudies == student.Study.IdStudies)
                {
                    StudyComboBox.SelectedIndex = StudyComboBox.Items.IndexOf(item);
                }
            }
            //StudyComboBox.SelectedItem = student.Study;
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
