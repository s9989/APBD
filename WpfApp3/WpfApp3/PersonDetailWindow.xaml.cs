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
using WpfApp3.Modele;

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy PersonDetailWindow.xaml
    /// </summary>
    public partial class PersonDetailWindow : Window
    {
        public PersonDetailWindow()
        {
            InitializeComponent();

            //Testowe dane dla kontrolki Grid
            var registrations = new List<Registration>();
            registrations.Add(new Registration { Date = new DateTime(2000, 10, 31), Semester = "2018/2019 letni", Specialization = "Informatyka" });
            registrations.Add(new Registration { Date = new DateTime(2001, 02, 28), Semester = "2018/2019 zimowy", Specialization = "Informatyka" });

            RegistrationDataGrid.ItemsSource = registrations;

            var statuses = new List<Status>();
            statuses.Add(new Status { DateFrom = new DateTime(2000, 10, 20), Specialization = "Informatyka", StatusText = "Student" });
            statuses.Add(new Status { DateFrom = new DateTime(2000, 02, 20), Specialization = "Informatyka", StatusText = "Urlop" });

            StatusDataGrid.ItemsSource = statuses;
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
