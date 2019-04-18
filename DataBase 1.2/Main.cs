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
    public partial class Febricart : Form
    {

        
        bool MouseDown;
        private Point lastLocation;

        public Febricart()
        {
            InitializeComponent();
            home1.BringToFront();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            lastLocation = e.Location;
        }
        
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
    

            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            product_ENtry1.BringToFront();



            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
        }

        private void entry1_Load(object sender, EventArgs e)
        {

        }

        private void login1_Load(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
       
            
            employee_INput1.BringToFront();

            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
        }

        private void view1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            create_new_account1.BringToFront();

            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (About ab = new About())
            {
                ab.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (Help hl = new Help())
            {
                hl.ShowDialog();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            using (Settings s = new Settings())
            {
                s.ShowDialog();
            }
        }
    }
}
