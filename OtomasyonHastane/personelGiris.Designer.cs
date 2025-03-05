namespace OtomasyonHastane
{
    partial class personelGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Form1 form1 = new Form1();
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
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customButton1 = new OtomasyonHastane.Scripts.CustomButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(66, 66, 66);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(288, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 25);
            textBox1.TabIndex = 0;
            textBox1.KeyDown += textBox1_Keydown;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(66, 66, 66);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(288, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 25);
            textBox2.TabIndex = 1;
            textBox2.KeyDown += textBox2_Keydown;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 27);
            label1.TabIndex = 2;
            label1.Text = "Çarşamba Devlet Hastanesi Personel Giriş Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(341, 133);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(364, 186);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 4;
            label3.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 382);
            label4.Name = "label4";
            label4.Size = new Size(765, 17);
            label4.TabIndex = 6;
            label4.Text = "Önemli Not: Eğer sistemde yeni isenize veya hastanede çalışmaya yeni başlamış iseniz lütfen yöneticiden şifre ve parolanızı alınız!! ";
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
            customButton1.Location = new Point(336, 240);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(99, 26);
            customButton1.TabIndex = 7;
            customButton1.Text = "Giriş Yap";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // personelGiris
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(773, 408);
            Controls.Add(customButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "personelGiris";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Scripts.CustomButton customButton1;
    }
}