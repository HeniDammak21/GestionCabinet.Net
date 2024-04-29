using Data;
using Domain.Entities;
using Service;
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
    public partial class AddPat : Form
    {
        public AddPat()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            //this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prenomPatTextBox.Text == "" || nomPatTextBox.Text == "" || sexeTextBox.Text == "" || adrPatTextBox.Text == "")
            {
                MessageBox.Show("Be careful, informration is empty !");
            }
            else {
                var newPatient = new Patient
                {
                    nomPat = nomPatTextBox.Text,
                    prenomPat = prenomPatTextBox.Text,
                    sexe = sexeTextBox.Text,
                    adrPat = adrPatTextBox.Text,

                };
                var patientService = new PatientService(new GestionCabinetContext());
                patientService.AddPatient(newPatient);
                Add_Load(sender, e);


                FormPatient pat = new FormPatient();
                pat.Show();
                this.Hide();
                MessageBox.Show("Add with sucsess !");
            }
            
        }

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
        }

        private void patientIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomPatLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomPatLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenomPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexeLabel_Click(object sender, EventArgs e)
        {

        }

        private void sexeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adrPatLabel_Click(object sender, EventArgs e)
        {

        }

        private void adrPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
        }
    }
}
