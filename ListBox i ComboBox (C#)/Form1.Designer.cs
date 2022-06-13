
namespace ListBox_i_ComboBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.ImieBox = new System.Windows.Forms.MaskedTextBox();
            this.PeselBox = new System.Windows.Forms.MaskedTextBox();
            this.NazwiskoBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deklaracja przystąpienia do egzaminu maturalnego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imię: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesel: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nazwisko: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(14, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Płeć";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(34, 30);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(75, 20);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = "Kobieta";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(162, 30);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(96, 20);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = "Mężczyzna";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.Location = new System.Drawing.Point(364, 75);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(105, 24);
            this.cb1.TabIndex = 8;
            this.cb1.Text = "Język polski";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb2.Location = new System.Drawing.Point(364, 101);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(105, 17);
            this.cb2.TabIndex = 9;
            this.cb2.Text = "Matematyka";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Biologia",
            "Chemia",
            "Fizyka",
            "Filozofia",
            "Religia"});
            this.listBox1.Location = new System.Drawing.Point(380, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 43);
            this.listBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Język angielski",
            "Język niemiecki",
            "Język francuski",
            "Język rosyjski",
            "Język hiszpanśki"});
            this.comboBox1.Location = new System.Drawing.Point(380, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // cb4
            // 
            this.cb4.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb4.Location = new System.Drawing.Point(364, 148);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(146, 17);
            this.cb4.TabIndex = 12;
            this.cb4.Text = "Przedmioty dodatkowe";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(449, 235);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 23);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "Zgłoś";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(364, 124);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 14);
            this.cb3.TabIndex = 14;
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // ImieBox
            // 
            this.ImieBox.Location = new System.Drawing.Point(101, 77);
            this.ImieBox.Mask = "LLLLLLLLLLLLLLL";
            this.ImieBox.Name = "ImieBox";
            this.ImieBox.Size = new System.Drawing.Size(187, 20);
            this.ImieBox.TabIndex = 15;
            // 
            // PeselBox
            // 
            this.PeselBox.Location = new System.Drawing.Point(101, 125);
            this.PeselBox.Mask = "99999999999";
            this.PeselBox.Name = "PeselBox";
            this.PeselBox.Size = new System.Drawing.Size(187, 20);
            this.PeselBox.TabIndex = 16;
            // 
            // NazwiskoBox
            // 
            this.NazwiskoBox.Location = new System.Drawing.Point(101, 100);
            this.NazwiskoBox.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLL";
            this.NazwiskoBox.Name = "NazwiskoBox";
            this.NazwiskoBox.Size = new System.Drawing.Size(187, 20);
            this.NazwiskoBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 278);
            this.Controls.Add(this.NazwiskoBox);
            this.Controls.Add(this.PeselBox);
            this.Controls.Add(this.ImieBox);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.MaskedTextBox ImieBox;
        private System.Windows.Forms.MaskedTextBox PeselBox;
        private System.Windows.Forms.MaskedTextBox NazwiskoBox;
    }
}

