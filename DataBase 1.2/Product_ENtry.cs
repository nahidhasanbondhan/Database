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
    public partial class Product_ENtry : UserControl
    {
        private string connectionString, query , id2 ;
        private SqlConnection connection;
        public Product_ENtry()
        {
            InitializeComponent();
            view_all();
        }
        void view_all()
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
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please fill ID");
                }
                else
                {


                    connection.Open();
                    query = "INSERT INTO product VALUES (@id,@Size,@Price,@Gender,@Type,@Color,@ImportDate,@ProductName,@ManufacturingCountry,@Quantity)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Size", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Type", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Color", comboBox4.Text);
                    cmd.Parameters.AddWithValue("@ImportDate", dateTimePicker1.Value.ToString());
                    cmd.Parameters.AddWithValue("@ProductName", textBox7.Text);
                    cmd.Parameters.AddWithValue("@ManufacturingCountry", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox9.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_all();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button1.Enabled = false;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                comboBox1.Text = row.Cells["Size"].Value.ToString();
                textBox2.Text = row.Cells["Price"].Value.ToString();
                comboBox2.Text = row.Cells["Gender"].Value.ToString();
                comboBox3.Text = row.Cells["Type"].Value.ToString();
                comboBox4.Text = row.Cells["Color"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ImportDate"].Value.ToString();
                textBox7.Text = row.Cells["ProductName"].Value.ToString();
                textBox6.Text = row.Cells["ManufacturingCountry"].Value.ToString();
                textBox9.Text = row.Cells["Quantity"].Value.ToString();
                id2 = row.Cells["Id"].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button1.Enabled = false;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                comboBox1.Text = row.Cells["Size"].Value.ToString();
                textBox2.Text = row.Cells["Price"].Value.ToString();
                comboBox2.Text = row.Cells["Gender"].Value.ToString();
                comboBox3.Text = row.Cells["Type"].Value.ToString();
                comboBox4.Text = row.Cells["Color"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ImportDate"].Value.ToString();
                textBox7.Text = row.Cells["ProductName"].Value.ToString();
                textBox6.Text = row.Cells["ManufacturingCountry"].Value.ToString();
                textBox9.Text = row.Cells["Quantity"].Value.ToString();
                id2 = row.Cells["Id"].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && comboBox2.Text != "" && comboBox3.Text == ""&&textBox7.Text=="")
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM product  WHERE Gender = @id2";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id2", comboBox2.Text);

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
            else if (textBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text != "" && textBox7.Text == "")
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM product  WHERE Type = @id2";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id2", comboBox3.Text);

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
            else if (textBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && textBox7.Text != "")
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM product  WHERE ProductName = @id2";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id2", textBox7.Text);

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
            else
            {
                try
                {
                    connectdatabase();
                    connection.Open();
                    query = "DELETE FROM product  WHERE Id = @id2";
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
            if (textBox3.Text == "")
            {
                view_all();
            }
            else
            {
                try
                {

                    connectdatabase();
                    connection.Open();

                    query = "SELECT * FROM product  WHERE  ManufacturingCountry = '" + textBox3.Text + "' OR Id = '" + textBox3.Text + "' OR Size = '" + textBox3.Text + "' OR Gender = '" + textBox3.Text + "' OR Type = '" + textBox3.Text + "' OR Color = '" + textBox3.Text + "' OR ProductName = '" + textBox3.Text + "'";

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

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    connectdatabase();
                    connection.Open();
                    query = "SELECT * FROM product  WHERE  (ManufacturingCountry LIKE '%" + textBox3.Text + "%' OR Id LIKE '%" + textBox3.Text + "%' OR Size LIKE '%" + textBox3.Text + "%' OR Gender LIKE '%" + textBox3.Text + "%' OR Type LIKE '%" + textBox3.Text + "%' OR Color LIKE '%" + textBox3.Text + "%' OR ProductName LIKE '%" + textBox3.Text + "%')";

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




        private void Product_ENtry_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                connectdatabase();
                connection.Open();
                query = "SELECT * FROM product  WHERE  ImportDate between '"+dateTimePicker2.Value.ToString()+ "' and '" + dateTimePicker3.Value.ToString()+"'";
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connectdatabase();
                connection.Open();
                query = "UPDATE product SET Id = @id , Size = @size , Price = @price , Gender = @gender , Type = @type, Color = @color , ImportDate = @importdate, ProductName = @productname ,ManufacturingCountry = @manufacturingcountry, Quantity = @Quantity    WHERE Id = @id2";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@size", comboBox1.Text);
                cmd.Parameters.AddWithValue("@price", textBox2.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox2.Text);
                cmd.Parameters.AddWithValue("@type", comboBox3.Text);
                cmd.Parameters.AddWithValue("@color", comboBox4.Text);
                cmd.Parameters.AddWithValue("@importdate", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@productname", textBox7.Text);
                cmd.Parameters.AddWithValue("@manufacturingcountry", textBox6.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox9.Text);
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

        void clear()
        {
            button1.Enabled = true;
            textBox1.Text = textBox2.Text = comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = textBox7.Text = textBox6.Text = textBox9.Text = dateTimePicker1.Text = "";
        }
    }
}
