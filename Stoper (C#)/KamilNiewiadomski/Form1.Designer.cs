namespace KamilNiewiadomski
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.godz1 = new System.Windows.Forms.PictureBox();
            this.godz2 = new System.Windows.Forms.PictureBox();
            this.min1 = new System.Windows.Forms.PictureBox();
            this.min2 = new System.Windows.Forms.PictureBox();
            this.sek2 = new System.Windows.Forms.PictureBox();
            this.sek1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.godz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sek1)).BeginInit();
            this.SuspendLayout();
            // 
            // godz1
            // 
            this.godz1.BackColor = System.Drawing.Color.Transparent;
            this.godz1.Image = ((System.Drawing.Image)(resources.GetObject("godz1.Image")));
            this.godz1.Location = new System.Drawing.Point(9, 10);
            this.godz1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.godz1.Name = "godz1";
            this.godz1.Size = new System.Drawing.Size(87, 147);
            this.godz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.godz1.TabIndex = 0;
            this.godz1.TabStop = false;
            // 
            // godz2
            // 
            this.godz2.BackColor = System.Drawing.Color.Transparent;
            this.godz2.Image = ((System.Drawing.Image)(resources.GetObject("godz2.Image")));
            this.godz2.Location = new System.Drawing.Point(100, 10);
            this.godz2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.godz2.Name = "godz2";
            this.godz2.Size = new System.Drawing.Size(87, 147);
            this.godz2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.godz2.TabIndex = 1;
            this.godz2.TabStop = false;
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.Image = ((System.Drawing.Image)(resources.GetObject("min1.Image")));
            this.min1.Location = new System.Drawing.Point(232, 10);
            this.min1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(87, 147);
            this.min1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min1.TabIndex = 2;
            this.min1.TabStop = false;
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.Image = ((System.Drawing.Image)(resources.GetObject("min2.Image")));
            this.min2.Location = new System.Drawing.Point(323, 10);
            this.min2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(87, 147);
            this.min2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.min2.TabIndex = 3;
            this.min2.TabStop = false;
            // 
            // sek2
            // 
            this.sek2.BackColor = System.Drawing.Color.Transparent;
            this.sek2.Image = ((System.Drawing.Image)(resources.GetObject("sek2.Image")));
            this.sek2.Location = new System.Drawing.Point(550, 10);
            this.sek2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sek2.Name = "sek2";
            this.sek2.Size = new System.Drawing.Size(87, 147);
            this.sek2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sek2.TabIndex = 5;
            this.sek2.TabStop = false;
            // 
            // sek1
            // 
            this.sek1.BackColor = System.Drawing.Color.Transparent;
            this.sek1.Image = ((System.Drawing.Image)(resources.GetObject("sek1.Image")));
            this.sek1.Location = new System.Drawing.Point(458, 10);
            this.sek1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sek1.Name = "sek1";
            this.sek1.Size = new System.Drawing.Size(87, 147);
            this.sek1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sek1.TabIndex = 4;
            this.sek1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "8.png");
            this.imageList1.Images.SetKeyName(9, "9.png");
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(125, 174);
            this.start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(98, 46);
            this.start.TabIndex = 11;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(269, 174);
            this.stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(98, 46);
            this.stop.TabIndex = 12;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(413, 174);
            this.reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(98, 46);
            this.reset.TabIndex = 13;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 229);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.sek2);
            this.Controls.Add(this.sek1);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.godz2);
            this.Controls.Add(this.godz1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.godz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sek1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox godz1;
        private System.Windows.Forms.PictureBox godz2;
        private System.Windows.Forms.PictureBox min1;
        private System.Windows.Forms.PictureBox min2;
        private System.Windows.Forms.PictureBox sek2;
        private System.Windows.Forms.PictureBox sek1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Timer timer1;
    }
}

