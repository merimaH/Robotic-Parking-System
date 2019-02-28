using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace RoboticParkingSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Postavite kažiprst na senzor!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String ime = textBox1.Text;
            String prezime = textBox2.Text;
            String adresa = textBox4.Text;
            String vozacka = maskedTextBox1.Text;
            String registracija = textBox3.Text;
            // validacija podataka i postavljanje da su pogresni
            // doda se errorprovider kontrola, samo se prevuce tamo 
            //validacija imena 
            if (Regex.Matches(ime, @"[a-zA-Z]").Count != ime.Length || ime.Length == 0)
            {
                errorProvider1.SetError(textBox1, "Neispravno ime.");
            }
            else
                errorProvider1.SetError(textBox1, "");

            //validacija prezimena 
            if (Regex.Matches(prezime, @"[a-zA-Z]").Count != prezime.Length || prezime.Length == 0)
                errorProvider1.SetError(textBox2, "Neispravno prezime.");
            else
                errorProvider1.SetError(textBox2, "");


            //validacija da registracija mora biti 9 znakova
            if (registracija.Length != 9)
                errorProvider1.SetError(textBox3, "Pogrešna registarska oznaka");
            else
                errorProvider1.SetError(textBox3, "");

            //validacija da se mora unijet adresa
            if (adresa.Length == 0)
                errorProvider1.SetError(textBox4, "Morate unijeti adresu.");
            else
                errorProvider1.SetError(textBox4, "");
            // treba postaviti da je inicijalno null
            if (pictureBox1.Image == null)
                errorProvider1.SetError(button1, "Potreban je otisak prsta");
            else
                errorProvider1.SetError(button1, "");

            if (vozacka.Length == 0)
                errorProvider1.SetError(maskedTextBox1, "Neispravan serijski broj.");
            else
                errorProvider1.SetError(maskedTextBox1, "");

            //Klijenti_lista.data.Add(new Client(textBox1.Text, textBox2.Text, textBox3.Text, pictureBox1.Image));
        }
    }
}
