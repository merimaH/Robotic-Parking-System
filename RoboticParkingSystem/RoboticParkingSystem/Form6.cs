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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(72, 126, 176);
            button1.ForeColor = SystemColors.ControlLightLight;

            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.ControlText;

            button3.BackColor = Color.FromArgb(72, 126, 176);
            button3.ForeColor = SystemColors.ControlLightLight;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(72, 126, 176);
            button1.ForeColor = SystemColors.ControlLightLight;

            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.ControlText;

            button2.BackColor = Color.FromArgb(72, 126, 176);
            button2.ForeColor = SystemColors.ControlLightLight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(72, 126, 176);
            button2.ForeColor = SystemColors.ControlLightLight;

            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;

            button3.BackColor = Color.FromArgb(72, 126, 176);
            button3.ForeColor = SystemColors.ControlLightLight;
        }
    }
}
