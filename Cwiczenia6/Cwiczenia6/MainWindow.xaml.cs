using Cwiczenia6.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cwiczenia6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Emp> Emps { get; set; }
        public List<Dept> Depts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            Emps = new List<Emp>();
            Depts = new List<Dept>();

            Emps.Add(new Emp
            {
                Empno = 7369,
                Ename = "SMITH",
                Job = "CLERK",
                Mgr = 7902,
                HireDate = new DateTime(1980, 12, 17),
                Sal=800,
                Comm=0,
                Deptno=20
            });

            Emps.Add(new Emp
            {
                Empno = 7499,
                Ename = "ALLEN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 20),
                Sal = 1600,
                Comm = 300,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7521,
                Ename = "WARD",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 22),
                Sal = 1250,
                Comm = 500,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7566,
                Ename = "JONES",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 4, 2),
                Sal = 2975,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7654,
                Ename = "MARTIN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 28),
                Sal = 1250,
                Comm = 1400,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7698,
                Ename = "BLAKE",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 5, 1),
                Sal = 2850,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7782,
                Ename = "CLARK",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 6, 9),
                Sal = 2450,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7788,
                Ename = "SCOTT",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate = new DateTime(1982, 12, 9),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7839,
                Ename = "KING",
                Job = "PRESIDENT",
                Mgr = null,
                HireDate = new DateTime(1981, 11, 17),
                Sal = 5000,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7844,
                Ename = "TURNER",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 8),
                Sal = 1500,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7876,
                Ename = "ADAMS",
                Job = "CLERK",
                Mgr = 7788,
                HireDate = new DateTime(1983, 1, 12),
                Sal = 1100,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7900,
                Ename = "JAMES",
                Job = "CLERK",
                Mgr = 7698,
                HireDate = new DateTime(1981, 12, 3),
                Sal = 950,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7902,
                Ename = "FORD",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate= new DateTime(1981, 12, 3),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7934,
                Ename = "MILLER",
                Job = "CLERK",
                Mgr = 7782,
                HireDate = new DateTime(1982, 1, 23),
                Sal = 1300,
                Comm = 0,
                Deptno = 10
            });

            Depts.Add(new Dept
            {
                Deptno=10,
                Dname= "ACCOUNTING",
                Loc= "NEW YORK"
            });

            Depts.Add(new Dept
            {
                Deptno = 20,
                Dname = "RESEARCH",
                Loc = "DALLAS"
            });

            Depts.Add(new Dept
            {
                Deptno = 30,
                Dname = "SALES",
                Loc = "CHICAGO"
            });

            Depts.Add(new Dept
            {
                Deptno = 40,
                Dname = "OPERATIONS",
                Loc = "BOSTON"
            });
        }

        private void Example()
        {
            //Query syntax
            var result = from e in Emps
                         where e.Ename.StartsWith("K")
                         select e;

            //Lambda and Extension methods syntax
            var result2 = Emps.Where(e => e.Ename.StartsWith("K"));


            DataGrid.ItemsSource = result.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs ev)
        {
            // 8 DataGrid.ItemsSource = Emps.OrderBy(e => e.Ename).ToList();
            /* 2 var result = from e in Emps
                         select new
                         {
                             EMPLOYEE = e.Empno + e.Ename
                         };
            DataGrid.ItemsSource = result.ToList();
            */
            // 9 DataGrid.ItemsSource = Emps.OrderByDescending(e => e.HireDate).ToList();

            // 14 DataGrid.ItemsSource = Emps.Where(emp => emp.Sal > 1000 && emp.Sal < 2000).ToList();
            // 16 DataGrid.ItemsSource = Emps.Where(e => e.Ename.StartsWith("S"));
            // 19 DataGrid.ItemsSource = Emps.Where(emp => emp.Sal < 1000 || emp.Sal > 2000).ToList();

            // 22 DataGrid.ItemsSource = Emps.Where(emp => emp.Job == "CLERK" && emp.Sal >= 1000 && emp.Sal < 2000).ToList();
            // 23 DataGrid.ItemsSource = Emps.Where(emp => emp.Job == "CLERK" || (emp.Sal >= 1000 && emp.Sal < 2000)).ToList();

            // 24 DataGrid.ItemsSource = Emps.Where(emp => emp.Job == "SALESMAN" || (emp.Job == "MANAGER" && emp.Sal > 1500)).ToList();
            // 25 DataGrid.ItemsSource = Emps.Where(emp => (emp.Job == "SALESMAN" || emp.Job == "MANAGER") && emp.Sal > 1500).ToList();


            // --- 

            // 1 DataGrid.ItemsSource = Emps.Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new DeptEmp(dept, emp)).ToList();
            /* 4  DataGrid.ItemsSource = Emps
                .Where(emp => emp.Sal > 1500)
                .Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new { Name = emp.Ename, Loc = dept.Loc, Dname = dept.Dname })
                .ToList();
                */

            /* 5 DataGrid.ItemsSource = Emps
                .Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new DeptEmp(dept, emp))
                .Where(empdep => empdep.Loc == "DALLAS")
                .ToList();
                */
            DataGrid.ItemsSource = Depts
                .Where(dept => dept.Deptno == 30 || dept.Deptno == 10)
                .Join(Emps, dept => dept.Deptno, emp => emp.Deptno, (dept, emp) => new { emp.Job, dept.Deptno })
                .GroupBy(emp => emp.Job)
                .ToList();
        }
    }
}
