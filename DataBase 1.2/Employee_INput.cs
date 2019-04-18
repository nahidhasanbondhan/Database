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
    public partial class Employee_INput : UserControl
    {
        private string connectionString, query , id2;
        private SqlConnection connection;
        public Employee_INput()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
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



        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox5.Text;
            if (textBox5.Text != "")
            {
                if (n.Length != 11)
                {
                    MessageBox.Show("Invalid Contact Number Number should be like 01*********");
                }
                else
                {
                    try
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Please fill ID");
                        }
                        else
                        {
                            connectdatabase();
                            connection.Open();
                            query = "INSERT INTO Employee(Id,Name,Post,Address,ContactNumber,Email) VALUES (@id,@name,@post,@address,@contactNumber,@email)";
                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@id", textBox1.Text);
                            cmd.Parameters.AddWithValue("@name", textBox2.Text);
                            cmd.Parameters.AddWithValue("@post", textBox3.Text);
                            cmd.Parameters.AddWithValue("@address", textBox4.Text);
                            cmd.Parameters.AddWithValue("@contactNumber", textBox5.Text);
                            cmd.Parameters.AddWithValue("@email", textBox8.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Entry Successfull");
                            connection.Close();
                            clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                try
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please fill ID");
                    }
                    else
                    {
                        connectdatabase();
                        connection.Open();
                        query = "INSERT INTO Employee(Id,Name,Post,Address,ContactNumber,Email) VALUES (@id,@name,@post,@address,@contactNumber,@email)";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", textBox1.Text);
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@post", textBox3.Text);
                        cmd.Parameters.AddWithValue("@address", textBox4.Text);
                        cmd.Parameters.AddWithValue("@contactNumber", textBox5.Text);
                        cmd.Parameters.AddWithValue("@email", textBox8.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Entry Successfull");
                        connection.Close();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    button1.Enabled = false;
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["Id"].Value.ToString();
                    textBox2.Text = row.Cells["Name"].Value.ToString();
                    textBox3.Text = row.Cells["Post"].Value.ToString();
                    textBox4.Text = row.Cells["Address"].Value.ToString();
                    textBox5.Text = row.Cells["ContactNumber"].Value.ToString();
                    textBox8.Text = row.Cells["Email"].Value.ToString();
                    id2 = row.Cells["Id"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connectdatabase();
                connection.Open();
                query = "SELECT * FROM Employee";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button1.Enabled = false;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Post"].Value.ToString();
                textBox4.Text = row.Cells["Address"].Value.ToString();
                textBox5.Text = row.Cells["ContactNumber"].Value.ToString();
                textBox8.Text = row.Cells["Email"].Value.ToString();
                id2 = row.Cells["Id"].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox3.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do You Sure Want To Reset ", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM Employee  WHERE Post = @id2";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id2", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfull");
                    connection.Close();
                    clear();
                }
            }
            else
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM Employee  WHERE Id = @id2";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id2", id2);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfull");
                    connection.Close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connectdatabase();
                connection.Open();
                query = "SELECT * FROM Employee  WHERE Id LIKE '%" + textBox6.Text + "%' OR Name LIKE '%" + textBox6.Text + "%' OR Post LIKE '%" + textBox6.Text + "%' OR Address LIKE '%" + textBox6.Text + "%' OR ContactNumber LIKE '%" + textBox6.Text + "%' OR Email LIKE '%" + textBox6.Text + "%'";

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

        

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "SELECT * FROM Employee  WHERE Id LIKE '%" + textBox6.Text + "%' OR Name LIKE '%" + textBox6.Text + "%' OR Post LIKE '%" + textBox6.Text + "%' OR Address LIKE '%" + textBox6.Text + "%' OR ContactNumber LIKE '%" + textBox6.Text + "%' OR Email LIKE '%" + textBox6.Text + "%'";

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

        private void Employee_INput_Load(object sender, EventArgs e)
        {
            try
            {
                connectdatabase();
                connection.Open();
                query = "SELECT * FROM Employee";
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

        private void button4_Click(object sender, EventArgs e)
        {
            string n = textBox5.Text;
            if (textBox5.Text != "")
            {
                if (n.Length != 11)
                {
                    MessageBox.Show("Invalid Contact Number Number should be like 01*********");
                }
                else
                {
                    try
                    {
                        connectdatabase();
                        connection.Open();
                        query = "UPDATE Employee SET Id = @id , Name = @name , Post = @post , Address = @address , ContactNumber = @contactnumber, Email = @email WHERE Id = @id2";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", textBox1.Text);
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@post", textBox3.Text);
                        cmd.Parameters.AddWithValue("@address", textBox4.Text);
                        cmd.Parameters.AddWithValue("@contactNumber", textBox5.Text);
                        cmd.Parameters.AddWithValue("@email", textBox8.Text);
                        cmd.Parameters.AddWithValue("@id2", id2);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Update Successfull");
                        connection.Close();
                        clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "UPDATE Employee SET Id = @id , Name = @name , Post = @post , Address = @address , ContactNumber = @contactnumber, Email = @email WHERE Id = @id2";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@post", textBox3.Text);
                    cmd.Parameters.AddWithValue("@address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@contactNumber", textBox5.Text);
                    cmd.Parameters.AddWithValue("@email", textBox8.Text);
                    cmd.Parameters.AddWithValue("@id2", id2);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfull");
                    connection.Close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        void clear()
        {
            button1.Enabled = true;
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox8.Text = "";
        }


    }
}
