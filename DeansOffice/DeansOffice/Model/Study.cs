﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.Model
{
    public class Study
    {
        public int IdStudies { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
