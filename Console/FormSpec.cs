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
    public partial class FormSpec : Form
    {

        public FormSpec()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Specialites'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.specialitesTableAdapter.Fill(this.gestionCabinetDataSet.Specialites);

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            var newSpecialite = new Specialite
            {
                nomSpec = nomSpecTextBox.Text,


            };
            var specialiteService = new SpecialiteService(new GestionCabinetContext());
            specialiteService.AddSpecilaite(newSpecialite);
            Form1_Load(sender, e);
        }*/

        private void specialitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void nomSpecTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void specialiteIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            specialitesBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddSpec spec = new AddSpec();
            spec.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateSpec spec = new UpdateSpec();
            spec.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteSpec spec = new DeleteSpec();
            spec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
