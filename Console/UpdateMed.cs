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
    public partial class UpdateMed : Form
    {
        public UpdateMed()
        {
            InitializeComponent();
        }

        private void medecinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medecinsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void UpdateMed_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinsTableAdapter.Fill(this.gestionCabinetDataSet.Medecins);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(medecinIDTextBox.Text);


            string nom = nomMedTextBox.Text;
            string prenom = prenomMedTextBox.Text;
            string adr = adreMedTextBox.Text;
            int numtel = Convert.ToInt32(numTelTextBox.Text);
            int specialiteID = Convert.ToInt32(comboBox1.SelectedValue);



            var updatedMed = new Medecin
            {
                MedecinID = id,
                nomMed = nom,
                prenomMed = prenom,
                adreMed = adr,
                numTel = numtel,

                SpecialiteID = specialiteID,

            };
            MedecinService medService = new MedecinService(new GestionCabinetContext());
            medService.UpdateMedecin(updatedMed);
            UpdateMed_Load(sender, e);
            FormMed med = new FormMed();
            med.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMed med = new FormMed();
            med.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMed med = new FormMed();
            med.Show();
            this.Hide();
        }
    }
}
