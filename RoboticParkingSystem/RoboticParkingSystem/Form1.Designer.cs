namespace RoboticParkingSystem
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.name = new System.Windows.Forms.Label();
            this.pasvord = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.lozinkatxt = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.registracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.name.Location = new System.Drawing.Point(32, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(111, 29);
            this.name.TabIndex = 1;
            this.name.Text = "Korisnik:";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // pasvord
            // 
            this.pasvord.AutoSize = true;
            this.pasvord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pasvord.Location = new System.Drawing.Point(38, 96);
            this.pasvord.Name = "pasvord";
            this.pasvord.Size = new System.Drawing.Size(108, 29);
            this.pasvord.TabIndex = 2;
            this.pasvord.Text = "Lozinka:";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(189, 57);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(234, 22);
            this.nametxt.TabIndex = 3;
            this.nametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lozinkatxt
            // 
            this.lozinkatxt.Location = new System.Drawing.Point(189, 103);
            this.lozinkatxt.Name = "lozinkatxt";
            this.lozinkatxt.Size = new System.Drawing.Size(234, 22);
            this.lozinkatxt.TabIndex = 4;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login.Location = new System.Drawing.Point(304, 159);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 41);
            this.login.TabIndex = 5;
            this.login.Text = "Prijava";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // registracija
            // 
            this.registracija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registracija.Location = new System.Drawing.Point(189, 159);
            this.registracija.Name = "registracija";
            this.registracija.Size = new System.Drawing.Size(109, 41);
            this.registracija.TabIndex = 6;
            this.registracija.Text = "Registracija";
            this.registracija.UseVisualStyleBackColor = true;
            this.registracija.Click += new System.EventHandler(this.registracija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(571, 345);
            this.Controls.Add(this.registracija);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lozinkatxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.pasvord);
            this.Controls.Add(this.name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pasvord;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox lozinkatxt;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button registracija;
    }
}

