using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataBase_1._2
{
    public partial class Home : UserControl
    {
        private string connectionString, query, id2;
        private SqlConnection connection;
        public Home()
        {
            InitializeComponent();



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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.storageDataSet.product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_search();
        }
        void main_search()
        {
            string type, size, gender;
            type = comboBox1.Text;
            size = comboBox2.Text;
            gender = comboBox3.Text;

            if (type == "" && size == "" && gender == "")
            {
                if (textBox1.Text != "")
                    allsearch();
                else
                    View();


            }
            else if (type == "" && size == "" && gender != "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Gender = '" + gender + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Size = '" + textBox1.Text + "' OR Type = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Gender = '" + gender + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            else if (type == "" && size != "" && gender == "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Size = '" + size + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Gender = '" + textBox1.Text + "' OR Type = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Size = '" + size + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }
            else if (type == "" && size != "" && gender != "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Size = '" + size + "') AND (Gender = '" + gender + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Type = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Size = '" + size + "') AND (Gender = '" + gender + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else if (type != "" && size == "" && gender == "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Type = '" + type + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Gender = '" + textBox1.Text + "' OR Size = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Type = '" + type + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else if (type != "" && size == "" && gender != "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Type = '" + type + "') AND (Gender = '" + gender + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Size = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Type = '" + type + "') AND (Gender = '" + gender + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else if (type != "" && size != "" && gender == "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Type = '" + type + "') AND (Size = '" + size + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Gender = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Type = '" + type + "') AND (Size = '" + size + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else if (type != "" && size != "" && gender != "")
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Gender = '" + gender + "') AND (Type = '" + type + "') AND (Size = '" + size + "') AND (ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else if (textBox1.Text == "")
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "SELECT * FROM product  WHERE (Gender = '" + gender + "') AND (Type = '" + type + "') AND (Size = '" + size + "')";

                        SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;


                        connection.Close();
                        clear();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        void allsearch()
        {
            try
            {
                connectdatabase();
                connection.Open();
                query = "SELECT * FROM product  WHERE ManufacturingCountry = '" + textBox1.Text + "' OR Id = '" + textBox1.Text + "' OR Size = '" + textBox1.Text + "' OR Gender = '" + textBox1.Text + "' OR Type = '" + textBox1.Text + "' OR Color = '" + textBox1.Text + "' OR ProductName = '" + textBox1.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;


                connection.Close();
                clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void clear()
        {
            comboBox1.Text = comboBox2.Text = comboBox3.Text = textBox1.Text = "";
        }

        void View()
        {
            try
            {
                connectdatabase();
                connection.Open();
                query = "SELECT * FROM product";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            View();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox2.Text = row.Cells["Id"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox2.Text = row.Cells["Id"].Value.ToString();
                    id2 = row.Cells["Quantity"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //
            try
            {
                int i,total;
                connectdatabase();
                connection.Open();
                query = "UPDATE product SET Quantity = @Quantity    WHERE Id = @id2";
                SqlCommand cmd = new SqlCommand(query, connection);

                i = Convert.ToInt32(textBox3.Text);
                total = Convert.ToInt32(id2);
                if (total > i)
                {
                    i = total - i;
                    cmd.Parameters.AddWithValue("@quantity", i.ToString());
                    cmd.Parameters.AddWithValue("@id2", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfull");
                    connection.Close();
                    textBox2.Text = textBox3.Text = "";
                }
                else
                    MessageBox.Show("Quantity less than what you want to purchase");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                main_search();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
