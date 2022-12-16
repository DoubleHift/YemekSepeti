using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace YemekSepeti1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-GE9HF51\\SQLEXPRESS;Initial Catalog=Musteriler;Integrated Security=TrueData Source=DESKTOP-GE9HF51\\SQLEXPRESS;Initial Catalog=Musteriler;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into Musteri_Bilgi(Kullanici_Adi,Ad_Soyad,Telefon_No) values(@Kullanici_ad,@AdS,@Telefon)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@Kullanici_ad", txt_Kad.Text);
                komut.Parameters.AddWithValue("@AdS", txt_AdSoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txt_telefon.Text);
                komut.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Kayit Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + " " + hata.Message);
            }
            Form1 form1= new Form1();
            form1.Show();
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
    }
    }

