using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticParkingSystem
{
    public partial class mis : Form { 

        PictureBox auto = new PictureBox();
        TextBox kraj = new TextBox();
        Button lijevodugme = new Button();
        Button desnodugme = new Button();
        Button poruka = new Button();
        TextBox upute = new TextBox();
    
        public mis()
        {
            InitializeComponent();
            kraj = this.textBox1;
            kraj.Visible = false;
            poruka = this.button1;
            poruka.Visible = false;
            upute = this.textBox2;
            upute.Visible = true;

        }
      



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        int y = 0;
        bool drag = false;
        private void moveObj1_MouseDown(object sender, MouseEventArgs e)
        {
            //Uzimanje poziciije kursora
            x = e.X;
            y = e.Y;
            drag = true;
        }

        private void moveObj1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                auto = this.moveObj1;
                if (auto.Location.X > 250 && auto.Location.X < 287 && auto.Location.Y > 122 && auto.Location.Y < 180)
                {
                    kraj.Visible = true;
                    poruka.Visible = true;
                    upute.Visible = false;
                }
                else
                {
                    kraj.Visible = false;
                    poruka.Visible = false;
                    upute.Visible = true;
                }
                //Nova pozovija kursora
                moveObj1.Top += e.Y-y;
                moveObj1.Left += e.X - x;

            }
        }

        private void moveObj1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
