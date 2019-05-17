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
                Sal = 800,
                Comm = 0,
                Deptno = 20
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
                HireDate = new DateTime(1981, 12, 3),
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
                Deptno = 10,
                Dname = "ACCOUNTING",
                Loc = "NEW YORK"
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

        public static String implodeEmps(List<Emp> emps)
        {
            String result = "";

            foreach (Emp emp in emps)
            {
                result = result + emp.Ename + ", ";
            }

            return result;
        }

        public static String implodeDeps(List<Dept> depts)
        {
            String result = "";

            foreach (Dept dept in depts)
            {
                result = result + dept.Dname + ", ";
            }

            return result;
        }

        private void Simple_8(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Posortuj wszystkie dane tabeli EMP według ENAME.";

            DataGrid.ItemsSource = Emps.OrderBy(e => e.Ename).ToList();
        }

        private void Simple_2(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Połącz EMPNO i nazwisko, opatrz je nagłówkiem EMPLOYEE.";

            var result = from e in Emps select new { EMPLOYEE = e.Empno + e.Ename };
            DataGrid.ItemsSource = result.ToList();
        }

        private void Simple_9(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Posortuj malejąco wszystkie dane tabeli EMP według daty ich zatrudnienia począwszy od ostatnio zatrudnionych.";

            DataGrid.ItemsSource = Emps.OrderByDescending(e => e.HireDate).ToList();
        }

        private void Simple_14(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz dane tych pracowników, których zarobki mieszczą się pomiędzy 1000 a 2000.";

            DataGrid.ItemsSource = Emps.Where(emp => emp.Sal > 1000 && emp.Sal < 2000).ToList();
        }

        private void Simple_16(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz dane tych pracowników, których nazwiska zaczynają się na S.";

            DataGrid.ItemsSource = Emps.Where(e => e.Ename.StartsWith("S"));
        }

        private void Simple_19(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz dane tych pracowników, których zarobki są poza przedziałem <1000,2000>.";

            DataGrid.ItemsSource = Emps.Where(emp => emp.Sal < 1000 || emp.Sal > 2000).ToList();
        }

        private void Simple_22(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz dane tych pracowników zatrudnionych na stanowisku CLERK których zarobki SAL mieszczą się w przedziale < 1000.2000).";

            DataGrid.ItemsSource = Emps.Where(emp => emp.Job == "CLERK" && emp.Sal >= 1000 && emp.Sal < 2000).ToList();
        }

        private void Simple_23(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz dane pracowników zatrudnionych na stanowisku CLERK albo takich, których zarobki SAL mieszczą się w przedziale<1000.2000).";

            DataGrid.ItemsSource = Emps.Where(emp => emp.Job == "CLERK" || (emp.Sal >= 1000 && emp.Sal < 2000)).ToList();
        }

        private void Simple_24(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz wszystkich pracowników zatrudnionych na stanowisku MANAGER z pensją powyżej 1500 oraz wszystkich pracowników na stanowisku SALESMAN, niezależnie od pensji.";

            DataGrid.ItemsSource = Emps.Where(emp => emp.Job == "SALESMAN" || (emp.Job == "MANAGER" && emp.Sal > 1500)).ToList();
        }

        private void Simple_25(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz wszystkich pracowników zatrudnionych na stanowisku MANAGER lub na stanowisku SALESMAN lecz zarabiających powyżej 1500.";

            DataGrid.ItemsSource = Emps.Where(emp => (emp.Job == "SALESMAN" || emp.Job == "MANAGER") && emp.Sal > 1500).ToList();
        }

        private void Link_1(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Połącz dane z tabel EMP i DEPT przy pomocy INNER JOIN.";

            DataGrid.ItemsSource = Emps.Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new DeptEmp(dept, emp)).ToList();
        }

        private void Link_4(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Dla pracowników o miesięcznej pensji powyżej 1500 podaj ich nazwiska, miejsca usytuowania ich departamentów oraz nazwy tych departamentów.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Sal > 1500)
                .Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new { Name = emp.Ename, Loc = dept.Loc, Dname = dept.Dname })
                .ToList();
        }

        private void Link_5(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz pracowników zatrudnionych w Dallas.";

            DataGrid.ItemsSource = Emps
                .Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new DeptEmp(dept, emp))
                .Where(empdep => empdep.Loc == "DALLAS")
                .ToList();
        }

        private void Link_3(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wybierz nazwiska wszystkich pracowników wraz z numerami i nazwami departamentów w których są zatrudnieni.";

            DataGrid.ItemsSource = Emps
                .Join(Depts, dept => dept.Deptno, emp => emp.Deptno, (emp, dept) => new
                {
                    Ename = emp.Ename,
                    Deptno = dept.Deptno,
                    Dname = dept.Dname
                })
                .ToList();
        }

        private void Link_6(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Wypisz dane wszystkich działów oraz ich pracowników tak, aby dane działu pojawiły się, nawet jeśli nie ma w dziale żadnego pracownika.";

            DataGrid.ItemsSource = Depts
                .GroupJoin(Emps, emp => emp.Deptno, dept => dept.Deptno, (dept, emps) => new
                {
                    Dname = dept.Dname,
                    Emps = implodeEmps(emps.ToList())
                })
                .ToList();
        }

        private void Group_4(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Oblicz średnie zarobki na każdym ze stanowisk pracy.";

            DataGrid.ItemsSource = Emps
                .GroupBy(emp => emp.Job)
                .Select(empg => new { Job = empg.Key, AvgSal = Math.Round(empg.Average(e => e.Sal), 2) })
                .ToList();
        }

        private void Group_3(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź ilu pracowników zatrudniono w departamencie 20.";

            DataGrid.ItemsSource = Depts
                .GroupJoin(Emps, emp => emp.Deptno, dept => dept.Deptno, (dept, emps) => new
                {
                    Deptno = dept.Deptno,
                    EmpCount = emps.Count()
                })
                .Where(dept => dept.Deptno == 20)
                .ToList();
        }

        private void Group_5(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Oblicz średnie zarobki na każdym ze stanowisk pracy z wyjątkiem stanowiska MANAGER.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Job != "MANAGER")
                .GroupBy(emp => emp.Job)
                .Select(empg => new { Job = empg.Key, AvgSal = Math.Round(empg.Average(e => e.Sal), 2) })
                .ToList();
        }

        private void Group_7(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Dla każdego stanowiska oblicz maksymalne zarobki.";

            DataGrid.ItemsSource = Emps
                .GroupBy(emp => emp.Job)
                .Select(empg => new { Job = empg.Key, MaxSal = empg.Max(e => e.Sal) })
                .ToList();
        }

        private void Group_2(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź minimalne zarobki na stanowisku CLERK.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Job == "CLERK")
                .GroupBy(emp => emp.Job)
                .Select(empg => new { Job = empg.Key, MinSal = empg.Min(e => e.Sal) })
                .ToList();
        }

        private void Subquery_1(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź pracowników z pensją równą minimalnemu zarobkowi w firmie.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Sal == Emps.Min(e => e.Sal))
                .ToList();
        }

        private void Subquery_9(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź pracowników, których zarobki przekraczają najwyższe pensje z departamentu SALES.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Sal > Emps
                            .Join(Depts, emp1 => emp1.Deptno, dept => dept.Deptno, (emp1, dept) => new DeptEmp(dept, emp1))
                            .Where(deptemp => deptemp.Dname == "SALES")
                            .Max(de => de.Sal)
                )
                .ToList();
        }

        private void Subquery_10(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź pracowników, którzy zarabiają powyżej średniej w ich departamentach.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Sal > Emps
                            .Join(Depts, emp1 => emp1.Deptno, dept => dept.Deptno, (emp1, dept) => new DeptEmp(dept, emp1))
                            .Where(deptemp => deptemp.Deptno == emp.Deptno)
                            .Average(de => de.Sal)
                )
                .ToList();
        }

        private void Subquery_4(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź pracowników o najniższych zarobkach w ich departamentach.";

            DataGrid.ItemsSource = Emps
                .Where(emp => emp.Sal == Emps.Where(e => e.Deptno == emp.Deptno).Min(e1 => e1.Sal))
                .ToList();
        }

        private void Subquery_8(object sender, RoutedEventArgs ev)
        {
            Query.Text = "Znajdź stanowisko, na którym są najwyższe średnie zarobki.";

            DataGrid.ItemsSource = Emps
                .GroupBy(emp => emp.Job)
                .Select(empg => new { Job = empg.Key, MaxSal = empg.Max(e => e.Sal) })
                .Where(eg => eg.MaxSal == Emps.Where(e1 => e1.Job == eg.Job).Max(e2 => e2.Sal));
        }
    }
}
