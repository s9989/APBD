using System;

namespace Cwiczenia6.Models
{
    public class DeptEmp
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }

        public int Empno { get; set; }
        public string Ename { get; set; }
        public int Sal { get; set; }
        public int? Comm { get; set; }
        public int? Mgr { get; set; }
        public DateTime HireDate { get; set; }
        public string Job { get; set; }

        public DeptEmp(Dept dept, Emp emp)
        {
            this.Deptno = dept.Deptno;
            this.Dname = dept.Dname;
            this.Loc = dept.Loc;

            this.Empno = emp.Empno;
            this.Ename = emp.Ename;
            this.Sal = emp.Sal;
            this.Comm = emp.Comm;
            this.Mgr = emp.Mgr;
            this.HireDate = emp.HireDate;
            this.Job = emp.Job;
        }
    }
}
