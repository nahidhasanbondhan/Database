using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBase_1._2
{
    public partial class Create_new_account : UserControl
    {
        String connectionString;
        SqlConnection connection;
        String query;
        String s = "admin";

        public Create_new_account()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""||textBox1.Text=="")
                {
                    MessageBox.Show("Please Fill All");
                }
                else if (textBox1.Text!=textBox4.Text)
                {
                    MessageBox.Show("Password didn't match");
                }
                else
                {


                    connectionString =
                    @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\soft and study\Study\3-1\Database\Database latest\Database 3.0 Old1\Database 3.0 Old\DataBase 1.3\DataBase 1.2\Storage.mdf; Integrated Security = True";
                    connection = new SqlConnection(connectionString);

                    connection.Open();
                    query = "INSERT INTO Login(Id,Password,MemType) VALUES (@id,@password,@memtype)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", textBox3.Text);
                    cmd.Parameters.AddWithValue("@password", textBox4.Text);
                    cmd.Parameters.AddWithValue("@memtype", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successfull");
                    connection.Close();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        void clear()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Text = "";
        }
    }
}
