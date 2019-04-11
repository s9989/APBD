using DeansOffice.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeansOffice.DAL
{
    class StudentsDbService
    {
        private string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\workspace\\apbd\\DeansOffice\\DeansOffice\\Database1.mdf;Integrated Security=True";

        public List<Student> AllStudents()
        {
            var ListaStudentow = new List<Student>();

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();

                using (SqlCommand Command = new SqlCommand("select * from apbd.Student s1 join apbd.Studies s2 on s1.IdStudies = s2.IdStudies", Connection))
                {
                    using (SqlDataReader DataReader = Command.ExecuteReader())
                    {
                        while (DataReader.Read())
                        {
                            Student student = new Student
                            {
                                IdStudent = (int)DataReader["IdStudent"],
                                FirstName = DataReader["FirstName"].ToString(),
                                LastName = DataReader["LastName"].ToString(),
                                Address = DataReader["Address"].ToString(),
                                IndexNumber = DataReader["IndexNumber"].ToString(),
                                IdStudies = (int)DataReader["IdStudies"]
                            };

                            student.Study = new Study
                            {
                                IdStudies = (int)DataReader["IdStudies"],
                                Name = DataReader["Name"].ToString()
                            };

                            ListaStudentow.Add(student);
                        }
                    }

                }
            }

            return ListaStudentow;
        }

        public void RemoveStudents(List<Student> toRemove)
        {
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                var Transaction = Connection.BeginTransaction();

                using (SqlCommand Command = new SqlCommand("delete from apbd.Student where IdStudent = @IdStudent", Connection, Transaction))
                {
                    foreach (Student student in toRemove)
                    {
                        Command.Parameters.Clear();
                        Command.Parameters.AddWithValue("@IdStudent", student.IdStudent);
                        Command.ExecuteNonQuery();
                    }

                }

                Transaction.Commit();
            }
        }
    }
}
