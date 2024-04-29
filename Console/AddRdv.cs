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
    public partial class AddRdv : Form
    {
        public AddRdv()
        {
            InitializeComponent();
        }

        private void rendezvousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rendezvousBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void AddRdv_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestionCabinetDataSet.Medecins);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Rendezvous'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.rendezvousTableAdapter.Fill(this.gestionCabinetDataSet.Rendezvous);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateRdvTextBox.Text == "" )
            {
                MessageBox.Show("Attention une informration est vide !");
            }
            else
            {
                var newRdvt = new Rendezvous
                {
                    dateRdv = dateRdvTextBox.Text,
                    PatientID = Convert.ToInt32(comboBox1.SelectedValue),
                    MedecinID = Convert.ToInt32(comboBox2.SelectedValue),


                };
                var rdvService = new RendezvousService(new GestionCabinetContext());
                rdvService.AddRendezvous(newRdvt);
                AddRdv_Load(sender, e);
                FormRdv rdv = new FormRdv();
                rdv.Show();
                this.Hide();
                MessageBox.Show("Add with sucsess !");

            }

            
        }

        private void dateRdvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRdv rdv = new FormRdv();
            rdv.Show();
            this.Hide();

        }
    }
}
