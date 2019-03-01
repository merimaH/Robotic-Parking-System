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
    public partial class Form1 : Form
    {
        string usernameSup = "supervizor";
        string passwordSup = "supervizor";
        string usernameVlasnik = "vlasnik";
        string passwordVlasnik = "vlasnik";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            // ako je supervizor
            if ((nametxt.Text!=usernameSup || lozinkatxt.Text != passwordSup)&&(nametxt.Text != usernameVlasnik || lozinkatxt.Text!= passwordVlasnik))
            {
                errorProvider1.SetError(nametxt, "Netačni podaci");
                errorProvider1.SetError(lozinkatxt, "Netačni podaci");
                //nametxt.Focus();
                nametxt.Select(); // selektuje tekst da se lakse promijeni posto je pogresan
                nametxt.SelectAll();
            }
            else if (nametxt.Text == usernameSup)
            {
                new Form4().Show(); //ako je supervizor otvara njegovu formu
                this.Hide();

            }
            else
            {
                new Form6().Show(); // ako je vlasnik otvara njegovu
                this.Hide();
            }
        }

        private void registracija_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lozinkatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void lozinkatxt_KeyDown(object sender, KeyEventArgs e)
        {
            // za provjeru jel pritisnut enter 
            if (e.KeyCode == Keys.Enter)
                login_Click(this, e);
                
        }

        private void lozinkatxt_Enter(object sender, EventArgs e)
        {
            lozinkatxt.SelectAll();
        }
    }
}
