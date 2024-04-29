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
    public partial class UpdateCons : Form
    {
        public UpdateCons()
        {
            InitializeComponent();
        }

        private void consultationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void UpdateCons_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Consultations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.consultationsTableAdapter.Fill(this.gestionCabinetDataSet.Consultations);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormConsultation cons = new FormConsultation();
            cons.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(consultationIDTextBox.Text);


            string date = dateConsTextBox.Text;
            string recap = recapConsTextBox.Text;
            int patientID = Convert.ToInt32(comboBox1.SelectedValue);



            var updatedCons = new Consultation
            {
                ConsultationID = id,
                dateCons = date,
                recapCons = recap,
                PatientID = patientID,

            };
            ConsultationService consService = new ConsultationService(new GestionCabinetContext());
            consService.UpdateConsultation(updatedCons);
            UpdateCons_Load(sender, e);
            FormConsultation cons = new FormConsultation();
            cons.Show();
            this.Hide();
        }
    }
}
