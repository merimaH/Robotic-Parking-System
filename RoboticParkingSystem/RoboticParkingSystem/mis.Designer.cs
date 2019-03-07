namespace RoboticParkingSystem
{
    partial class mis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moveObj1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nazad = new System.Windows.Forms.TextBox();
            this.nazadpanel = new System.Windows.Forms.Panel();
            this.lijevo = new System.Windows.Forms.TextBox();
            this.lijevopanel = new System.Windows.Forms.Panel();
            this.desno = new System.Windows.Forms.TextBox();
            this.desnopanel = new System.Windows.Forms.Panel();
            this.napredpanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uuu = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moveObj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.napredpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(4, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Možete napustiti automobil";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox1.ForeColor = System.Drawing.Color.Peru;
            this.textBox1.Location = new System.Drawing.Point(4, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(235, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Uspješno ste parkirali !";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(247, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 271);
            this.panel1.TabIndex = 3;
            // 
            // moveObj1
            // 
            this.moveObj1.Image = global::RoboticParkingSystem.Properties.Resources.auto11;
            this.moveObj1.Location = new System.Drawing.Point(168, 218);
            this.moveObj1.Margin = new System.Windows.Forms.Padding(4);
            this.moveObj1.Name = "moveObj1";
            this.moveObj1.Size = new System.Drawing.Size(106, 218);
            this.moveObj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveObj1.TabIndex = 0;
            this.moveObj1.TabStop = false;
            this.moveObj1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.moveObj1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveObj1_MouseDown);
            this.moveObj1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveObj1_MouseMove);
            this.moveObj1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveObj1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RoboticParkingSystem.Properties.Resources.ikona;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 276);
            this.panel2.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.Color.Aqua;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(4, 59);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(236, 97);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Potrebno je pazljivo pozicionirati automobil na oznacenu lokaciju";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status parkiranja automobila:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel3.Controls.Add(this.moveObj1);
            this.panel3.Controls.Add(this.nazad);
            this.panel3.Controls.Add(this.nazadpanel);
            this.panel3.Controls.Add(this.lijevo);
            this.panel3.Controls.Add(this.desno);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.lijevopanel);
            this.panel3.Controls.Add(this.desnopanel);
            this.panel3.Controls.Add(this.napredpanel);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel3.Location = new System.Drawing.Point(258, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 504);
            this.panel3.TabIndex = 6;
            // 
            // nazad
            // 
            this.nazad.BackColor = System.Drawing.Color.SkyBlue;
            this.nazad.Location = new System.Drawing.Point(273, 443);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(99, 30);
            this.nazad.TabIndex = 7;
            this.nazad.Text = "Nazad";
            this.nazad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nazadpanel
            // 
            this.nazadpanel.BackColor = System.Drawing.Color.Red;
            this.nazadpanel.Location = new System.Drawing.Point(247, 392);
            this.nazadpanel.Name = "nazadpanel";
            this.nazadpanel.Size = new System.Drawing.Size(150, 113);
            this.nazadpanel.TabIndex = 11;
            // 
            // lijevo
            // 
            this.lijevo.BackColor = System.Drawing.Color.SkyBlue;
            this.lijevo.Location = new System.Drawing.Point(62, 252);
            this.lijevo.Name = "lijevo";
            this.lijevo.Size = new System.Drawing.Size(99, 30);
            this.lijevo.TabIndex = 5;
            this.lijevo.Text = "Lijevo";
            this.lijevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lijevopanel
            // 
            this.lijevopanel.BackColor = System.Drawing.Color.Red;
            this.lijevopanel.Location = new System.Drawing.Point(0, 0);
            this.lijevopanel.Name = "lijevopanel";
            this.lijevopanel.Size = new System.Drawing.Size(252, 505);
            this.lijevopanel.TabIndex = 10;
            // 
            // desno
            // 
            this.desno.BackColor = System.Drawing.Color.SkyBlue;
            this.desno.Location = new System.Drawing.Point(453, 249);
            this.desno.Name = "desno";
            this.desno.Size = new System.Drawing.Size(99, 30);
            this.desno.TabIndex = 4;
            this.desno.Text = "Desno";
            this.desno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // desnopanel
            // 
            this.desnopanel.BackColor = System.Drawing.Color.Red;
            this.desnopanel.Location = new System.Drawing.Point(396, 0);
            this.desnopanel.Name = "desnopanel";
            this.desnopanel.Size = new System.Drawing.Size(183, 504);
            this.desnopanel.TabIndex = 9;
            // 
            // napredpanel
            // 
            this.napredpanel.BackColor = System.Drawing.Color.Red;
            this.napredpanel.Controls.Add(this.button2);
            this.napredpanel.Controls.Add(this.uuu);
            this.napredpanel.Location = new System.Drawing.Point(247, 0);
            this.napredpanel.Name = "napredpanel";
            this.napredpanel.Size = new System.Drawing.Size(149, 122);
            this.napredpanel.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(240, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 530);
            this.panel4.TabIndex = 4;
            // 
            // uuu
            // 
            this.uuu.BackColor = System.Drawing.Color.SkyBlue;
            this.uuu.Location = new System.Drawing.Point(26, 56);
            this.uuu.Name = "uuu";
            this.uuu.Size = new System.Drawing.Size(99, 30);
            this.uuu.TabIndex = 0;
            this.uuu.Text = "Napred";
            this.uuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Location = new System.Drawing.Point(26, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Napred";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // mis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mis";
            this.Text = "mis";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mis_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.moveObj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.napredpanel.ResumeLayout(false);
            this.napredpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox moveObj1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox desno;
        private System.Windows.Forms.TextBox lijevo;
        private System.Windows.Forms.TextBox nazad;
        private System.Windows.Forms.Panel napredpanel;
        private System.Windows.Forms.Panel desnopanel;
        private System.Windows.Forms.Panel lijevopanel;
        private System.Windows.Forms.Panel nazadpanel;
        private System.Windows.Forms.TextBox uuu;
        private System.Windows.Forms.Button button2;
    }
}