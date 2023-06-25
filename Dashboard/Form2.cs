using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Npgsql;

namespace Dashboard
{

    

    public partial class Form2 : Form
    {

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=proje; user Id=postgres; password=5355");
        NpgsqlCommand komut;
        NpgsqlDataReader reader;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        
        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public bool ParolaKontrol()
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                komut = new NpgsqlCommand("Select * from kullanicilar where kullanici_adi='" + textBox1.Text + "'", baglanti);
                reader = komut.ExecuteReader();
                if (reader.Read() == true)
                {

                    if (reader["pw"].ToString() == textBox2.Text)
                    {
                        return true;

                    }
                    else
                    {
                        return false;

                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception hataMesaj)
            {
                MessageBox.Show(hataMesaj.ToString());
                throw;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void btnDashbord_Click_1(object sender, EventArgs e)
        {
            if (ParolaKontrol() == true)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya parola...");
            }
        }


        private void btnAnalytics_Click(object sender, EventArgs e)
        {

        }

        private void btnCalender_Click(object sender, EventArgs e)
        {


        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {

        }

        private void btnsettings_Click(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {

        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {

        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {

        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

    }
}
