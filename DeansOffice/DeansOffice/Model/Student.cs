using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Model
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int IdStudent { get; set; } = 0;

        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
                }
            }
        }

        private string _LastName;
        public string LastName { get { return _LastName; } set { _LastName = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("LastName")); } }

        public string Address { get; set; } = "Warszawa";

        private string _IndexNumber;
        public string IndexNumber { get { return _IndexNumber; } set { _IndexNumber = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IndexNumber")); } }

        private int _IdStudies;
        public int IdStudies { get { return _IdStudies; } set { _IdStudies = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdStudies")); } }

        private Study _Study;
        public Study Study { get { return _Study; } set { _Study = value; if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Study")); } }
        public List<Subject> Subjects { get; set; }
    }
}
