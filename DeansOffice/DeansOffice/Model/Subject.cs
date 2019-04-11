using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Model
{
    class Subject
    {
        public int IdSubject { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
