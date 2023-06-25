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
using System.Data.SqlClient;
using Npgsql;

namespace Dashboard
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            buttonFilmler.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void customizeDesign()
        {
            panelAyarlar.Visible = false;
            panelKitaplar.Visible = false;
            panelFilmler.Visible = false;
            panelFilmGorsel.Visible = false;
            panelKitapGorsel.Visible = false;
            panelVenom.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            
            buttonFilmler.BackColor = Color.FromArgb(46, 51, 73);
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
            panelKitaplar.Visible = false;
            panelVenom.Visible = false;
            panelKitapGorsel.Visible = false;
            panelFilmler.Visible = false;
            panelFilmGorsel.Visible = false;
            panelAyarlar.Visible = true;
            
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            buttonFilmler.BackColor = Color.FromArgb(24, 30, 54);
        }



        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
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
            textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelAyarlar.Visible = false;
            panelKitaplar.Visible = false;
            panelVenom.Visible = false;
            panelKitapGorsel.Visible = false;
            panelFilmler.Visible = true;
            panelFilmGorsel.Visible = true;
            
        }

        private void buttonKitaplar_Click(object sender, EventArgs e)
        {
            panelAyarlar.Visible = false;
            panelVenom.Visible = false;
            panelFilmGorsel.Visible = false;
            panelFilmler.Visible = false;
            panelKitapGorsel.Visible = true;
            panelKitaplar.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            panelAyarlar.Visible = false;
            panelKitaplar.Visible = false;
            panelFilmler.Visible = false;
            panelFilmGorsel.Visible = false;
            panelKitapGorsel.Visible = false;
            panelVenom.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelVenom.Visible = false;
            panelFilmGorsel.Visible = true;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dl7.5fghhui78jnkopqwccgo2hellru6.xyz/Film/Zaban.Asli/2021/Venom.Let.There.Be.Carnage.2021.720p.AMZN.WEBRip.800MB.x264-GalaxyRG.Golchindl.mkv"); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelAyarlar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            komut = new NpgsqlCommand("UPDATE kullanicilar SET kullanici_adi ='" + textBox3.Text + "'", baglanti);
            reader = komut.ExecuteReader();
            baglanti.Close();
            label30.Text = textBox3.Text;
            label1.Text = textBox3.Text;
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
