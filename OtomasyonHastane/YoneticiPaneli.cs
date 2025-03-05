using MySqlConnector;
using OtomasyonHastane.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace hastaneOtomasyon
{
    public partial class YoneticiPaneli : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hastaneotomasyon;Uid=root";
        public YoneticiPaneli()
        {
            InitializeComponent();
            ButtonClicks buttonClicks = new ButtonClicks();
            customButton8.Click += (sender, e) => buttonClicks.HesapCikisBtn(this);
            customButton6.Click += (sender, e) => buttonClicks.EczaBtn(this);
            customButton5.Click += (sender, e) => buttonClicks.HastaBtn(this);
            customButton4.Click += (sender, e) => buttonClicks.PersonelYonetBtn(this);
            customButton1.Click += buttonClicks.ExitButton;
            customButton2.Click += (sender, e) => buttonClicks.MinimizedButton(this);
            customButton3.Click += (sender, e) => buttonClicks.AnasayfaBtn(this);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customButton9_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string username = ad.ToLower() + "." + soyad.ToLower();
            DateTime dogumTarihi = dateTimePicker1.Value;
            string tarihFormatli = dogumTarihi.ToString("yyyy-MM-dd");
            string cinsiyet = comboBox1.Text;
            string gorev = comboBox2.Text;
            string tckn = textBox3.Text;
            string tel = textBox4.Text;
            string mail = textBox5.Text;
            string password = GenerateSecurePassword(10);

            bool basari = KayitEkle(ad, soyad, dogumTarihi, cinsiyet, gorev, tckn, tel, mail,username,password);

            if (basari)
                MessageBox.Show("Kayıt başarılı!");
            else
                MessageBox.Show("Kayıt sırasında bir hata oluştu.");

            label16.Text = "Kullanıcı Adı: " + username;
            label17.Text = "Şifre: " + password;
        }

        private bool KayitEkle(string ad, string soyad, DateTime dogumTarihi, string cinsiyet, string gorev, string tckn, string tel, string mail,string username, string password)
        {
            bool basarili = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO personelliste (username, password, ad, soyad, cinsiyet, doğumtarihi, tc_no, telefon, email, görev, yönetimSeviyesi) " +
                           "VALUES (@username, @password, @ad, @soyad, @cinsiyet, @dogumtarihi, @tckn, @tel, @mail, @gorev, NULL)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@soyad", soyad);
                        cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        cmd.Parameters.AddWithValue("@dogumtarihi", dogumTarihi.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@tckn", tckn);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.Parameters.AddWithValue("@mail", mail);
                        cmd.Parameters.AddWithValue("@gorev", gorev);

                        int affectedRows = cmd.ExecuteNonQuery(); 
                        if (affectedRows > 0)
                            basarili = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }
            return basarili;
        }

        private string GenerateSecurePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
