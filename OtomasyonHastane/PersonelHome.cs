using OtomasyonHastane;
using OtomasyonHastane.Scripts;
using System;
using System.Windows.Forms;

namespace hastaneOtomasyon
{
    public partial class PersonelHome : Form
    {
        

        public PersonelHome()
        {
            InitializeComponent();
            ButtonClicks buttonClicks = new ButtonClicks();
            customButton8.Click += (sender, e) => buttonClicks.HesapCikisBtn(this);
            customButton7.Click += (sender, e) => buttonClicks.YoneticiBtn(this);
            customButton6.Click += (sender, e) => buttonClicks.EczaBtn(this);
            customButton5.Click += (sender, e) => buttonClicks.HastaBtn(this);
            customButton4.Click += (sender, e) => buttonClicks.PersonelYonetBtn(this);
            customButton1.Click += buttonClicks.ExitButton;
            customButton2.Click += (sender, e) => buttonClicks.MinimizedButton(this);
        }
    }
}
