using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMed med = new FormMed();
            //med.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSpec spec = new FormSpec();
            spec.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            FormMed med = new FormMed();
            med.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRdv rdv = new FormRdv();
            rdv.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormConsultation cons = new FormConsultation();
            cons.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            FormMed med = new FormMed();
            med.Show();
            this.Hide();
        }
    }
}
