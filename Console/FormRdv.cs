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
    public partial class FormRdv : Form
    {
        public FormRdv()
        {
            InitializeComponent();
        }

        private void rendezvousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rendezvousBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void FormRdv_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestionCabinetDataSet.Medecins);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Rendezvous'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rendezvousTableAdapter.Fill(this.gestionCabinetDataSet.Rendezvous);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rendezvousBindingSource.AddNew();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateRdvTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*int id = int.Parse(rendezvousIDTextBox.Text);


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
            FormRdv_Load(sender, e);*/
        }

        private void rendezvousIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            AddRdv add = new AddRdv();
            add.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateRdv up = new UpdateRdv();
            up.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteRdv de = new DeleteRdv();
            de.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
