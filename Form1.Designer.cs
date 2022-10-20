namespace kamehujek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.odpowiedz = new System.Windows.Forms.TextBox();
            this.wiadomosc = new System.Windows.Forms.Label();
            this.tries = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Graj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "sprawdź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // odpowiedz
            // 
            this.odpowiedz.Location = new System.Drawing.Point(225, 131);
            this.odpowiedz.Name = "odpowiedz";
            this.odpowiedz.Size = new System.Drawing.Size(100, 23);
            this.odpowiedz.TabIndex = 3;
            this.odpowiedz.TextChanged += new System.EventHandler(this.odpowiedz_TextChanged);
            // 
            // wiadomosc
            // 
            this.wiadomosc.AutoSize = true;
            this.wiadomosc.Location = new System.Drawing.Point(498, 76);
            this.wiadomosc.Name = "wiadomosc";
            this.wiadomosc.Size = new System.Drawing.Size(10, 15);
            this.wiadomosc.TabIndex = 4;
            this.wiadomosc.Text = " ";
            this.wiadomosc.Click += new System.EventHandler(this.wiadomosc_Click);
            // 
            // tries
            // 
            this.tries.AutoSize = true;
            this.tries.Location = new System.Drawing.Point(437, 80);
            this.tries.Name = "tries";
            this.tries.Size = new System.Drawing.Size(0, 15);
            this.tries.TabIndex = 5;
            this.tries.Click += new System.EventHandler(this.tries_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(678, 243);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(678, 190);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "100";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(678, 132);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 19);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "1500";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(678, 74);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 19);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "5000";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Maksymalna liczba ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(498, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 19);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Podpowiedzi wyłączone";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Podopowiedzi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Liczba prób";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tries);
            this.Controls.Add(this.wiadomosc);
            this.Controls.Add(this.odpowiedz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox odpowiedz;
        private Label wiadomosc;
        private Label tries;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
    }
}