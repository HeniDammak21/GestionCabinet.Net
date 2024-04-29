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
    public partial class FormConsultation : Form
    {
        public FormConsultation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var newConsult = new Consultation
            {
                dateCons = dateConsTextBox.Text,
                recapCons = recapConsTextBox.Text,
             PatientID = Convert.ToInt32(comboBox1.SelectedValue),
            };
            var consutService = new ConsultationService(new GestionCabinetContext());
            consutService.AddConsultation(newConsult);
            FormConsultation_Load(sender, e);*/
            AddRdv rdv = new AddRdv();
            rdv.Show();
            this.Hide();
        }

       

        private void consultationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Consultations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.consultationsTableAdapter.Fill(this.gestionCabinetDataSet.Consultations);

        }

        private void dateConsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recapConsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int id = int.Parse(consultationIDTextBox.Text);


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
            FormConsultation_Load(sender, e);*/
        }

        private void consultationIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            consultationsBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddCons cons = new AddCons();
            cons.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateCons cons = new UpdateCons();
            cons.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteCons cons = new DeleteCons();
            cons.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
