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
    public partial class DeleteRdv : Form
    {
        public DeleteRdv()
        {
            InitializeComponent();
        }

        private void rendezvousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rendezvousBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void DeleteRdv_Load(object sender, EventArgs e)
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
            DialogResult res = MessageBox.Show("Do you really want to delete this Consultation?", "Confirmation", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                RendezvousService r = new RendezvousService(new GestionCabinetContext());
            int id = int.Parse(rendezvousIDTextBox.Text);
            r.DeleteRendezvous(id);
            DeleteRdv_Load(sender, e);
            FormRdv rdv = new FormRdv();
            rdv.Show();
            this.Hide();
                MessageBox.Show("Delete successfully");
            }
            else
                MessageBox.Show("Deletion is ignored");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
