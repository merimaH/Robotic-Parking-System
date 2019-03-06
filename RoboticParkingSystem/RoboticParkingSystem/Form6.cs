using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'database2DataSet2.Klijenti' table. You can move, or remove it, as needed.
            //this.klijentiTableAdapter.Fill(this.database2DataSet2.Klijenti);
            DataTable dt = new DataTable("Klijenti");
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RoboticParkingSystem.Properties.Settings.Database2ConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                //nesto ne valja sa ovom naredbom
                string sqlNaredba = "select Klijenti.Ime,Klijenti.Prezime,Klijenti.Adresa,Klijenti.Registracija,Klijenti.Vozacka,Uplate.DatumUplate,datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) as 'Uplata vazi do' from Klijenti inner join Uplate on Uplate.ClientID = Klijenti.ClientID ";
                string sqlNaredba2 = "where datefromparts(year(Uplate.DatumUplate),month(Uplate.DatumUplate)+Uplate.BrojMjeseci,day(Uplate.DatumUplate)) >= GETDATE();";
                using (SqlDataAdapter da = new SqlDataAdapter(sqlNaredba+sqlNaredba2, cn))
                {

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                }
            }

            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Font = new Font("MS Sans Serif", 13);
            panel1.Visible = true;
            /*DataGridViewRow row1 = dataGridView1.Rows[0];
            DataGridViewRow row2 = dataGridView1.Rows[1];
            row1.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            row2.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(72, 126, 176);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Font = new Font("MS Sans Serif", 12);

            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.ControlText;
            button2.Font = new Font("MS Sans Serif", 13);

            button3.BackColor = Color.FromArgb(72, 126, 176);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Font = new Font("MS Sans Serif", 12);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(72, 126, 176);
            button1.ForeColor = SystemColors.ControlLightLight;

            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.ControlText;

            button2.BackColor = Color.FromArgb(72, 126, 176);
            button2.ForeColor = SystemColors.ControlLightLight;

            button1.Font = new Font("MS Sans Serif", 12);
            button2.Font = new Font("MS Sans Serif", 12);
            button3.Font = new Font("MS Sans Serif", 13);

            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(72, 126, 176);
            button2.ForeColor = SystemColors.ControlLightLight;

            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;

            button3.BackColor = Color.FromArgb(72, 126, 176);
            button3.ForeColor = SystemColors.ControlLightLight;

            button1.Font = new Font("MS Sans Serif", 13);
            button2.Font = new Font("MS Sans Serif", 12);
            button3.Font = new Font("MS Sans Serif", 12);

            panel1.Visible = true;
            DataGridViewRow row1 = dataGridView1.Rows[0];
            DataGridViewRow row2 = dataGridView1.Rows[1];
            row1.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            row2.DefaultCellStyle.BackColor = Color.FromArgb(198, 216, 232);
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
