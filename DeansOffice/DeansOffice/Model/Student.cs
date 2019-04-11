using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Model
{
    class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string IndexNumber { get; set; }
        public int IdStudies { get; set; }
        public Study Study { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
