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
            var students = new List<Student>();

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

                            students.Add(student);
                        }
                    }

                }
            }

            return students;
        }

        public List<Study> AllStudies()
        {
            var studies = new List<Study>();

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();

                using (SqlCommand Command = new SqlCommand("select * from apbd.Studies", Connection))
                {
                    using (SqlDataReader DataReader = Command.ExecuteReader())
                    {
                        while (DataReader.Read())
                        {
                            studies.Add(new Study
                            {
                                IdStudies = (int)DataReader["IdStudies"],
                                Name = DataReader["Name"].ToString()
                            });

                        }
                    }

                }
            }

            return studies;
        }

        public int AddStudent(Student student)
        {
            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                
                using (SqlCommand Command = new SqlCommand(
                    "insert into apbd.Student " +
                        "(FirstName, LastName, Address, IndexNumber, IdStudies) " +
                    "values (@FirstName, @LastName, @Address, @IndexNumber, @IdStudies)", Connection))
                {
                    Command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    Command.Parameters.AddWithValue("@LastName", student.LastName);
                    Command.Parameters.AddWithValue("@Address", student.Address);
                    Command.Parameters.AddWithValue("@IndexNumber", student.IndexNumber);
                    Command.Parameters.AddWithValue("@IdStudies", student.Study.IdStudies);
                    Command.ExecuteNonQuery();


                    Command.CommandText = "select MAX(IdStudent) as id from apbd.Student";
                    using (SqlDataReader DataReader = Command.ExecuteReader())
                    {
                        if (DataReader.Read())
                        {
                            return (int)DataReader["id"];
                        }
                    }
                            
                }

            }

            return 0;
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
