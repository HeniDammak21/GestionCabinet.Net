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
    public partial class DeleteMed : Form
    {
        public DeleteMed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this Consultation?", "Confirmation", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                MedecinService c = new MedecinService(new GestionCabinetContext());
                int id = int.Parse(medecinIDTextBox.Text);
                c.DeleteMedecin(id);
                DeleteMed_Load(sender, e);
                FormMed med = new FormMed();
                med.Show();
                this.Hide();
                MessageBox.Show("Delete successfully");
            }
            else
                MessageBox.Show("Deletion is ignored");
        }

        private void medecinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medecinsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void DeleteMed_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestionCabinetDataSet.Medecins);

        }

        private void medecinIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMed med = new FormMed();
            med.Show();
            this.Hide();
        }

        private void nomMedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomMedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numTelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adreMedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMed med = new FormMed();
            med.Show();
            this.Hide();
        }
    }
}
