namespace WindowsFormsApp2
{
    partial class Photoshop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Odczyt2 = new System.Windows.Forms.Button();
            this.odczytaj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.odczyt = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Odczyt2);
            this.panel1.Controls.Add(this.odczytaj);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Odczyt2
            // 
            this.Odczyt2.Location = new System.Drawing.Point(688, 12);
            this.Odczyt2.Name = "Odczyt2";
            this.Odczyt2.Size = new System.Drawing.Size(100, 28);
            this.Odczyt2.TabIndex = 1;
            this.Odczyt2.Text = "Odczyt 2 panelu";
            this.Odczyt2.UseVisualStyleBackColor = true;
            this.Odczyt2.Click += new System.EventHandler(this.Koniec_Click);
            // 
            // odczytaj
            // 
            this.odczytaj.Location = new System.Drawing.Point(12, 12);
            this.odczytaj.Name = "odczytaj";
            this.odczytaj.Size = new System.Drawing.Size(82, 28);
            this.odczytaj.TabIndex = 0;
            this.odczytaj.Text = "odczytaj";
            this.odczytaj.UseVisualStyleBackColor = true;
            this.odczytaj.Click += new System.EventHandler(this.odczytaj_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 373);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(296, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 373);
            this.panel3.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(279, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Przyciemnienie";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(373, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Proguj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Czarno-Białe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Rozjasnienie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "R-B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(446, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 373);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // odczyt
            // 
            this.odczyt.DefaultExt = "jpg";
            this.odczyt.FileName = "odczyt";
            this.odczyt.Filter = "pliki jpg|*.jpg|Wszystkie pliki|*.*";
            this.odczyt.Title = "odczyt";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Suma";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Odejmowanie";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 64);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Rożnica";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(194, 43);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Negatyw";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Mnożenie";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 122);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "Histogram";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(435, 44);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 22);
            this.button12.TabIndex = 11;
            this.button12.Text = "Kontrast";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Photoshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Photoshop";
            this.Text = "Photoshop";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Odczyt2;
        private System.Windows.Forms.Button odczytaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog odczyt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}

