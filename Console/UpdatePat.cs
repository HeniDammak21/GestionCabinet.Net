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
    public partial class UpdatePat : Form
    {
        public UpdatePat()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void UpdatePat_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(patientIDTextBox.Text);


            string nom = nomPatTextBox.Text;
            string prenom = prenomPatTextBox.Text;
            string sexe = sexeTextBox.Text;
            string adr = adrPatTextBox.Text;



            var updatePatient = new Patient
            {
                PatientID = id,
                nomPat = nom,
                prenomPat = prenom,
                sexe = sexe,
                adrPat = adr,



            };


            PatientService patientService = new PatientService(new GestionCabinetContext());
            patientService.UpdatePatient(updatePatient);
            UpdatePat_Load(sender, e);
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
        }

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void patientIDTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
