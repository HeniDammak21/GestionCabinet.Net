using Data;
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
    public partial class DeletePat : Form
    {
        public DeletePat()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void DeletePat_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this Consultation?", "Confirmation", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (res == DialogResult.OK) { 
                PatientService p = new PatientService(new GestionCabinetContext());
           int id = int.Parse(patientIDTextBox.Text);
           p.DeletePatient(id);
           DeletePat_Load(sender, e);
            FormPatient pat = new FormPatient();
            pat.Show();
            this.Hide();
            MessageBox.Show("Delete successfully");
            }
            else
                MessageBox.Show("Deletion is ignored");
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

        private void adrPatLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomPatLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
