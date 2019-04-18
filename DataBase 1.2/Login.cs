using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBase_1._2
{
    public partial class Login : Form
    {

        String connectionString;
        SqlConnection connection;
        String query;

        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DataBase_1._2.Properties.Settings.StorageConnectionString"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection(connectionString);
            connection.Open();

            query = "SELECT count(*) FROM Login Where Id = '"+textBox1.Text+ "' and Password = '" + textBox2.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query,connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                using (Febricart fd = new Febricart())
                {
                    fd.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please check your Username and Password");
            }

            connection.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
