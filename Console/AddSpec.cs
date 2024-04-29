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
    public partial class AddSpec : Form
    {
        public AddSpec()
        {
            InitializeComponent();
        }

        private void specialitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void AddSpec_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomSpecTextBox.Text == "")
            {
                MessageBox.Show("Be careful, informration is empty !");
            }
            else {
                var newSpecialite = new Specialite
                {
                    nomSpec = nomSpecTextBox.Text,


                };
                var specialiteService = new SpecialiteService(new GestionCabinetContext());
                specialiteService.AddSpecilaite(newSpecialite);
                AddSpec_Load(sender, e);
                FormSpec spec = new FormSpec();
                spec.Show();
                this.Hide();
                MessageBox.Show("Add with sucsess !");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSpec spec = new FormSpec();
            spec.Show();
            this.Hide();
        }

        private void nomSpecTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
