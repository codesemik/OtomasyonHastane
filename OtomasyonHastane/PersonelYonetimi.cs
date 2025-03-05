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

namespace hastaneOtomasyon
{
    public partial class PersonelYonetimi : Form
    {
        public PersonelYonetimi()
        {
            InitializeComponent();
            ButtonClicks buttonClicks = new ButtonClicks();
            customButton8.Click += (sender, e) => buttonClicks.HesapCikisBtn(this);
            customButton7.Click += (sender, e) => buttonClicks.YoneticiBtn(this);
            customButton6.Click += (sender, e) => buttonClicks.EczaBtn(this);
            customButton5.Click += (sender, e) => buttonClicks.HastaBtn(this);
            customButton1.Click += buttonClicks.ExitButton;
            customButton2.Click += (sender, e) => buttonClicks.MinimizedButton(this);
            customButton3.Click += (sender, e) => buttonClicks.AnasayfaBtn(this);
        }
    }
}
