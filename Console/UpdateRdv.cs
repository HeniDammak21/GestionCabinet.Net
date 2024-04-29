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
    public partial class UpdateRdv : Form
    {
        public UpdateRdv()
        {
            InitializeComponent();
        }

        private void rendezvousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rendezvousBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void UpdateRdv_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestionCabinetDataSet.Medecins);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Rendezvous'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rendezvousTableAdapter.Fill(this.gestionCabinetDataSet.Rendezvous);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(rendezvousIDTextBox.Text);


            string date = dateRdvTextBox.Text;
            int patientID = Convert.ToInt32(comboBox1.SelectedValue);
            int medecinID = Convert.ToInt32(comboBox2.SelectedValue);




            var updatedCons = new Rendezvous
            {
                RendezvousID = id,
                dateRdv = date,
                PatientID = patientID,
                MedecinID = medecinID,

            };
            RendezvousService consService = new RendezvousService(new GestionCabinetContext());
            consService.UpdateRendezvous(updatedCons);
            UpdateRdv_Load(sender, e);
            FormRdv rdv = new FormRdv();
            rdv.Show();
            this.Hide();
        }

        private void medecinIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRdv rdv = new FormRdv();
            rdv.Show();
            this.Hide();
        }
    }
}
