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
    public partial class UpdateSpec : Form
    {
        public UpdateSpec()
        {
            InitializeComponent();
        }

        private void specialitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void UpdateSpec_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomSpecTextBox.Text == "")
            {
                MessageBox.Show("Be careful, informration is empty !");
            }
            else
            {
                int id = int.Parse(specialiteIDTextBox.Text);


                string nom = nomSpecTextBox.Text;


                var updateSpecialite = new Specialite
                {
                    SpecialiteID = id,
                    nomSpec = nom,
                };


                SpecialiteService specialiteService = new SpecialiteService(new GestionCabinetContext());
                specialiteService.UpdateSpecilaite(updateSpecialite);
                UpdateSpec_Load(sender, e);
                FormSpec spec = new FormSpec();
                spec.Show();
                this.Hide();
                MessageBox.Show("Update with sucsess !");
            }
        }
            
        }

       
    
}
