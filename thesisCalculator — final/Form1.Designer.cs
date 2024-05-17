namespace Kalkulator_Prac_Dyplomowych
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_bwCount = new System.Windows.Forms.TextBox();
            this.textBox2_copies = new System.Windows.Forms.TextBox();
            this.textBox3_cCount = new System.Windows.Forms.TextBox();
            this.textBox4_totalPrice = new System.Windows.Forms.TextBox();
            this.comboBox1_cover = new System.Windows.Forms.ComboBox();
            this.comboBox2_bothSided = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1_count = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3_cCount2 = new System.Windows.Forms.TextBox();
            this.textBox2_copies2 = new System.Windows.Forms.TextBox();
            this.textBox1_bwCount2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox3_cd = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba stron cz-b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba stron w kolorze:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liczba kopii: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Typ oprawy: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Czy druk dwustronny?";
            // 
            // textBox1_bwCount
            // 
            this.textBox1_bwCount.AcceptsReturn = true;
            this.textBox1_bwCount.Location = new System.Drawing.Point(188, 50);
            this.textBox1_bwCount.Name = "textBox1_bwCount";
            this.textBox1_bwCount.Size = new System.Drawing.Size(100, 22);
            this.textBox1_bwCount.TabIndex = 5;
            this.textBox1_bwCount.Text = "0";
            this.textBox1_bwCount.TextChanged += new System.EventHandler(this.textBox1_bwCount_TextChanged);
            // 
            // textBox2_copies
            // 
            this.textBox2_copies.Location = new System.Drawing.Point(188, 250);
            this.textBox2_copies.Name = "textBox2_copies";
            this.textBox2_copies.Size = new System.Drawing.Size(100, 22);
            this.textBox2_copies.TabIndex = 6;
            this.textBox2_copies.Text = "1";
            this.textBox2_copies.TextChanged += new System.EventHandler(this.textBox2_copies_TextChanged);
            // 
            // textBox3_cCount
            // 
            this.textBox3_cCount.Location = new System.Drawing.Point(188, 100);
            this.textBox3_cCount.Name = "textBox3_cCount";
            this.textBox3_cCount.Size = new System.Drawing.Size(100, 22);
            this.textBox3_cCount.TabIndex = 7;
            this.textBox3_cCount.Text = "0";
            this.textBox3_cCount.TextChanged += new System.EventHandler(this.textBox3_cCount_TextChanged);
            // 
            // textBox4_totalPrice
            // 
            this.textBox4_totalPrice.Location = new System.Drawing.Point(681, 50);
            this.textBox4_totalPrice.Name = "textBox4_totalPrice";
            this.textBox4_totalPrice.ReadOnly = true;
            this.textBox4_totalPrice.Size = new System.Drawing.Size(150, 22);
            this.textBox4_totalPrice.TabIndex = 8;
            // 
            // comboBox1_cover
            // 
            this.comboBox1_cover.FormattingEnabled = true;
            this.comboBox1_cover.Location = new System.Drawing.Point(188, 200);
            this.comboBox1_cover.Name = "comboBox1_cover";
            this.comboBox1_cover.Size = new System.Drawing.Size(300, 24);
            this.comboBox1_cover.TabIndex = 9;
            // 
            // comboBox2_bothSided
            // 
            this.comboBox2_bothSided.FormattingEnabled = true;
            this.comboBox2_bothSided.Location = new System.Drawing.Point(188, 150);
            this.comboBox2_bothSided.Name = "comboBox2_bothSided";
            this.comboBox2_bothSided.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_bothSided.TabIndex = 10;
            this.comboBox2_bothSided.SelectedIndexChanged += new System.EventHandler(this.comboBox2_bothSided_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Łączna cena:";
            // 
            // button1_count
            // 
            this.button1_count.Location = new System.Drawing.Point(567, 100);
            this.button1_count.Name = "button1_count";
            this.button1_count.Size = new System.Drawing.Size(200, 50);
            this.button1_count.TabIndex = 12;
            this.button1_count.Text = "Oblicz";
            this.button1_count.UseVisualStyleBackColor = true;
            this.button1_count.Click += new System.EventHandler(this.button1_count_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Specyfikacja 1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 450);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 500);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // textBox3_cCount2
            // 
            this.textBox3_cCount2.Location = new System.Drawing.Point(188, 400);
            this.textBox3_cCount2.Name = "textBox3_cCount2";
            this.textBox3_cCount2.Size = new System.Drawing.Size(100, 22);
            this.textBox3_cCount2.TabIndex = 31;
            this.textBox3_cCount2.Text = "0";
            this.textBox3_cCount2.TextChanged += new System.EventHandler(this.textBox3_cCount2_TextChanged);
            // 
            // textBox2_copies2
            // 
            this.textBox2_copies2.Location = new System.Drawing.Point(188, 550);
            this.textBox2_copies2.Name = "textBox2_copies2";
            this.textBox2_copies2.Size = new System.Drawing.Size(100, 22);
            this.textBox2_copies2.TabIndex = 30;
            this.textBox2_copies2.Text = "0";
            this.textBox2_copies2.TextChanged += new System.EventHandler(this.textBox2_copies2_TextChanged);
            // 
            // textBox1_bwCount2
            // 
            this.textBox1_bwCount2.AcceptsReturn = true;
            this.textBox1_bwCount2.Location = new System.Drawing.Point(188, 350);
            this.textBox1_bwCount2.Name = "textBox1_bwCount2";
            this.textBox1_bwCount2.Size = new System.Drawing.Size(100, 22);
            this.textBox1_bwCount2.TabIndex = 29;
            this.textBox1_bwCount2.Text = "0";
            this.textBox1_bwCount2.TextChanged += new System.EventHandler(this.textBox1_bwCount2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Czy druk dwustronny?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Typ oprawy:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Liczba kopii:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Liczba stron w kolorze:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Liczba stron cz-b:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Specyfikacja 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(500, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 16);
            this.label15.TabIndex = 36;
            this.label15.Text = "Nagranie płyty:";
            // 
            // comboBox3_cd
            // 
            this.comboBox3_cd.FormattingEnabled = true;
            this.comboBox3_cd.Location = new System.Drawing.Point(681, 200);
            this.comboBox3_cd.Name = "comboBox3_cd";
            this.comboBox3_cd.Size = new System.Drawing.Size(121, 24);
            this.comboBox3_cd.TabIndex = 37;
            this.comboBox3_cd.SelectedIndexChanged += new System.EventHandler(this.comboBox3_cd_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 16);
            this.label14.TabIndex = 38;
            this.label14.Text = "Czy naklejka na płytę?";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(681, 250);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 39;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(500, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Liczba kopii:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(681, 300);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 42;
            this.textBox4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 740);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox3_cd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3_cCount2);
            this.Controls.Add(this.textBox2_copies2);
            this.Controls.Add(this.textBox1_bwCount2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2_bothSided);
            this.Controls.Add(this.comboBox1_cover);
            this.Controls.Add(this.textBox4_totalPrice);
            this.Controls.Add(this.textBox3_cCount);
            this.Controls.Add(this.textBox2_copies);
            this.Controls.Add(this.textBox1_bwCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator Prac Dyplomowych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_bwCount;
        private System.Windows.Forms.TextBox textBox2_copies;
        private System.Windows.Forms.TextBox textBox3_cCount;
        private System.Windows.Forms.TextBox textBox4_totalPrice;
        private System.Windows.Forms.ComboBox comboBox1_cover;
        private System.Windows.Forms.ComboBox comboBox2_bothSided;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1_count;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3_cCount2;
        private System.Windows.Forms.TextBox textBox2_copies2;
        private System.Windows.Forms.TextBox textBox1_bwCount2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox3_cd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
    }
}

