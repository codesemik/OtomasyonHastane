using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hastaneOtomasyon;
using MySqlConnector;
using System.Security.Cryptography;

namespace OtomasyonHastane
{
    public partial class personelGiris : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hastaneotomasyon;Uid=root";
        PersonelHome personelHome = new PersonelHome();
        public personelGiris()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            girisyap();
        }

        private bool Giris(string user, string passw)
        {
            bool basarili = false;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM personelliste WHERE username = @user AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@password", passw);
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            basarili = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }

            return basarili;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) 
            {
                return;
            }

            e.Handled = false;  
            textBox2.PasswordChar = '*'; 
        }
        // tetbıx 1 enter basınca 2. textbox eventi
        private void textBox1_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }
        //enter yapınca giris yap fonksiyon eventi
        private void textBox2_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                girisyap();
            }
        }

        public void girisyap()
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz");
            }
            else
            {
                if (Giris(username, password))
                {
                    personelHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş! Lütfen tekrar deneyiniz");
                }
            }
        }
    }
}
