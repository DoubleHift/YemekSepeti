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
using YemekSepeti1;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        static string constring = "Data Source=DESKTOP-GE9HF51\\SQLEXPRESS;Initial Catalog=Musteriler;Integrated Security=TrueData Source=DESKTOP-GE9HF51\\SQLEXPRESS;Initial Catalog=Musteriler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private Point a;


        public void sagkaydir()
        {
            foto1.Location = new Point(foto1.Location.X + 5, foto1.Location.Y);
            foto2.Location = new Point(foto2.Location.X + 5, foto2.Location.Y);
            foto3.Location = new Point(foto3.Location.X + 5, foto3.Location.Y);
            foto4.Location = new Point(foto4.Location.X + 5, foto4.Location.Y);

            foto5.Location = new Point(foto5.Location.X + 5, foto5.Location.Y);
            foto6.Location = new Point(foto6.Location.X + 5, foto6.Location.Y);
            foto7.Location = new Point(foto7.Location.X + 5, foto7.Location.Y);

            if (foto1.Location.X > 110)
            {
                foto5.Visible = false;
                foto1.Visible = true;
            }

            if (foto2.Location.X > 110)
            {
                foto6.Visible = false;
                foto2.Visible = true;
            }
            if (foto3.Location.X > 110)
            {
                foto7.Visible = false;
                foto3.Visible = true;
            }
            if (foto4.Location.X > 550)
            {
                foto4.Visible = false;
            }
            if (foto6.Location.X > 550)
            {
                foto6.Visible = false;
            }
            if (foto7.Location.X > 550)
            {
                foto7.Visible = false;
            }
            if (foto5.Location.X > 550)
            {
                foto5.Visible = false;
            }
        }
        public void solakaydir()
        {
            foto1.Location = new Point(foto1.Location.X - 5, foto1.Location.Y);
            foto2.Location = new Point(foto2.Location.X - 5, foto2.Location.Y);
            foto3.Location = new Point(foto3.Location.X - 5, foto3.Location.Y);
            foto4.Location = new Point(foto4.Location.X - 5, foto4.Location.Y);

            foto5.Location = new Point(foto5.Location.X - 5, foto5.Location.Y);
            foto6.Location = new Point(foto6.Location.X - 5, foto6.Location.Y);
            foto7.Location = new Point(foto7.Location.X - 5, foto7.Location.Y);

            if (foto1.Location.X < 110)
            {
                foto1.Visible = false;
                foto5.Visible = true;
            }

            if (foto2.Location.X < 110)
            {
                foto2.Visible = false;
                foto6.Visible = true;
            }
            if (foto3.Location.X < 110)
            {
                foto3.Visible = false;
                foto7.Visible = true;
            }
            if (foto4.Location.X < 110)
            {
                foto4.Visible = false;
            }
            if (foto6.Location.X < 110)
            {
                foto6.Visible = false;
            }
            if (foto7.Location.X < 110)
            {
                foto7.Visible = false;
            }
            if (foto5.Location.X < 110)
            {
                foto5.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
           // this.Hide();
            
            form2.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Kad_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sagkaydir();
           
        }



        private void button1_MouseDown_1(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            solakaydir();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            this.Hide();

            form3.Show();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
