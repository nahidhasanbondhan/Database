using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_1._2
{
    public partial class Settings : Form
    {
        private string connectionString, query, id2;
        private SqlConnection connection;
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Sure Want To Delete the Product Table ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM product ";
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Delete Successfull");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Sure Want To Delete the Employee Table ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM Employee ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Delete Successfull");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Sure Want To Reset ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM Employee ";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query = "DELETE FROM product ";
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Delete Successfull");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            
        }
        void connectdatabase()
        {
            try
            {
                connectionString =
                    @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\soft and study\Study\3-1\Database\Database latest\Database 3.0 Old1\Database 3.0 Old\DataBase 1.3\DataBase 1.2\Storage.mdf; Integrated Security = True";
                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
