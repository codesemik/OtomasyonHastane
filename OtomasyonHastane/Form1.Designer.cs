using OtomasyonHastane.Scripts;
using System.Xml.Linq;

namespace OtomasyonHastane
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Functions functions = new Functions();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Tasarım kodu buraya geliyor.
        /// </summary>
        private void InitializeComponent()
        {
            customButton1 = new CustomButton();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(48, 48, 48);
            customButton1.BackgroundColor = Color.FromArgb(48, 48, 48);
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 3;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(303, 171);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(166, 44);
            customButton1.TabIndex = 1;
            customButton1.Text = "Giriş ➜";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(773, 408);
            Controls.Add(customButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Paint += Otomasyon_Paint;
            MouseDown += Otomasyon_MouseDown;
            ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton1;
    }
}