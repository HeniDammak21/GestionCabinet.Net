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
    public partial class AddCons : Form
    {
        public AddCons()
        {
            InitializeComponent();
        }

        private void consultationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void AddCons_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Consultations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.consultationsTableAdapter.Fill(this.gestionCabinetDataSet.Consultations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateConsTextBox.Text=="" || recapConsTextBox.Text=="")
            {
                MessageBox.Show("Attention une informration est vide !");
            }
            else {

                var newConsult = new Consultation
                {
                    dateCons = dateConsTextBox.Text,
                    recapCons = recapConsTextBox.Text,
                    PatientID = Convert.ToInt32(comboBox1.SelectedValue),
                };
                var consutService = new ConsultationService(new GestionCabinetContext());
                consutService.AddConsultation(newConsult);
                AddCons_Load(sender, e);
                FormConsultation cons = new FormConsultation();
                cons.Show();
                this.Hide();
            }
            
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

        private void dateConsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recapConsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
