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
    public partial class AddMed : Form
    {
        public AddMed()
        {
            InitializeComponent();
        }

        private void medecinsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medecinsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void AddMed_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Medecins'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           // this.medecinsTableAdapter.Fill(this.gestionCabinetDataSet.Medecins);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prenomMedTextBox.Text == "" || nomMedTextBox.Text == "" || numTelTextBox.Text == "" || adreMedTextBox.Text == "")
            {
                MessageBox.Show("Be careful, informration is empty !");
            }
            else {
                try
                {
                    var newMed = new Medecin
                    {
                        nomMed = nomMedTextBox.Text,
                        prenomMed = prenomMedTextBox.Text,
                        adreMed = adreMedTextBox.Text,
                        numTel = Convert.ToInt32(numTelTextBox.Text),
                        SpecialiteID = Convert.ToInt32(comboBox1.SelectedValue),
                    };
                    var medService = new MedecinService(new GestionCabinetContext());
                    medService.AddMedecin(newMed);
                    AddMed_Load(sender, e);

                    FormMed med = new FormMed();
                    med.Show();
                    this.Hide();
                    MessageBox.Show("Add with sucsess !");
                }
                catch(FormatException)
                {
                    MessageBox.Show("Phone number invalid !");
                }
               
            }
            
        }

        private void specialiteIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void nomMedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numTelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomMedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adreMedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
