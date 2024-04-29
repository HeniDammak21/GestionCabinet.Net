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
    public partial class DeleteSpec : Form
    {
        public DeleteSpec()
        {
            InitializeComponent();
        }

        private void specialitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void DeleteSpec_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this Consultation?", "Confirmation", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {

                SpecialiteService s = new SpecialiteService(new GestionCabinetContext());
            int id = int.Parse(specialiteIDTextBox.Text);
            s.DeleteSpecilaite(id);
            DeleteSpec_Load(sender, e);
            FormSpec spec = new FormSpec();
            spec.Show();
            this.Hide();
                MessageBox.Show("Delete successfully");
            }
            else
                MessageBox.Show("Deletion is ignored");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSpec spec = new FormSpec();
            spec.Show();
            this.Hide();
        }
    }
}
