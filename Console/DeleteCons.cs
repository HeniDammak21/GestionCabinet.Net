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
    public partial class DeleteCons : Form
    {
        public DeleteCons()
        {
            InitializeComponent();
        }

        private void consultationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void DeleteCons_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Consultations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.consultationsTableAdapter.Fill(this.gestionCabinetDataSet.Consultations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this Consultation?", "Confirmation",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                ConsultationService c = new ConsultationService(new GestionCabinetContext());
                int id = int.Parse(consultationIDTextBox.Text);
                c.DeleteConsultation(id);
                DeleteCons_Load(sender, e);
                FormConsultation cons = new FormConsultation();
                cons.Show();
                this.Hide();
                MessageBox.Show("Delete successfully");
            }
            else
                MessageBox.Show("Deletion is ignored");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultation cons = new FormConsultation();
            cons.Show();
            this.Hide();
        }
    }
}
