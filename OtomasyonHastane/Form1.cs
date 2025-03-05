using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtomasyonHastane.Scripts;

namespace OtomasyonHastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Otomasyon_Paint(object sender, PaintEventArgs e)
        {
            Form form = sender as Form;
            if (form != null)
            {
                int borderSize = 5; 
        Color borderColor = Color.FromArgb(0x2F, 0x2F, 0x2F); 

                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, form.Width - 1, form.Height - 1));
                }
            }
        }
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public void Otomasyon_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = sender as Form;
            if (form != null && e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0xA1, 0x2, 0);
            }
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            personelGiris PersonelGiris = new personelGiris();
            PersonelGiris.Show();
            this.Hide();
        }

    }
}
