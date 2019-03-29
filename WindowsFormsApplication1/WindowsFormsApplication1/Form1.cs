using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Zakończ");
        }

        private void Forml_Load(object sender, EventArgs e) {
            //con = new SqlConnection(Properties.Settings.Default.testConnectionString); 
            Console.WriteLine(Properties.Settings.Default);
            con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s9989;Integrated Security=True");

            con.Open(); 
        } 

        private void buttonl_Click(object sender, EventArgs e) { 
            
            SqlCommand cmd = new SqlCommand(); 
                cmd.Connection = con; 
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.CommandText = "emp_del"; 
                cmd.Parameters.Add("@empno", SqlDbType.Int); 
                cmd.Parameters["@empno"].Value = 7369; 
                
            try { 
                cmd.ExecuteNonQuery(); 
            } catch {
                MessageBox.Show("Wystqpil blqd!"); 
            } 
        
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            con.Close(); 
        } 


    }
}
