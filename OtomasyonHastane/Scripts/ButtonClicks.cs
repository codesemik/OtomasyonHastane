using hastaneOtomasyon;
using System;
using System.Windows.Forms;

namespace OtomasyonHastane.Scripts
{
    class ButtonClicks
    {
        public void ExitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MinimizedButton(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
        public void EczaBtn(Form form)
        {
            EczaDeposu eczaDeposu = new EczaDeposu();
            eczaDeposu.Show();
            form.Hide();
        }

        public void PersonelYonetBtn(Form form)
        {
            PersonelYonetimi personelYonetimi = new PersonelYonetimi();
            personelYonetimi.Show();
            form.Hide();
        }

        public void HastaBtn(Form form)
        {
            HastaYonetimi hastaYonetimi = new HastaYonetimi();
            hastaYonetimi.Show();
            form.Hide();
        }

        public void YoneticiBtn(Form form)
        {
            YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
            yoneticiPaneli.Show();
            form.Hide();
        }

        public void HesapCikisBtn(Form form)
        {
            Form1 form1 = new Form1();
            form1.Show();
            form.Hide();
        }

        public void AnasayfaBtn(Form form)
        {
            PersonelHome personelHome = new PersonelHome();
            personelHome.Show();
            form.Hide();
        }
    }
}
