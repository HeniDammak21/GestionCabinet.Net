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
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Patients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.patientsTableAdapter.Fill(this.gestionCabinetDataSet.Patients);

        }

      

        private void nomPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adrPatTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*PatientService p = new PatientService(new GestionCabinetContext());
           // int id = int.Parse(patientIDTextBox.Text);
            p.DeletePatient(id);
            FormPatient_Load(sender, e);*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientsBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {



            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*var newPatient = new Patient
            {
                nomPat = nomPatTextBox.Text,
                prenomPat = prenomPatTextBox.Text,
                sexe = sexeTextBox.Text,
                adrPat = adrPatTextBox.Text,

            };
            var patientService = new PatientService(new GestionCabinetContext());
            patientService.AddPatient(newPatient);
            FormPatient_Load(sender, e);    */
            AddPat add = new AddPat();
            add.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*int id = int.Parse(patientIDTextBox.Text);


            string nom = nomPatTextBox.Text;
            string prenom = prenomPatTextBox.Text;
            string sexe = sexeTextBox.Text;
            string adr = adrPatTextBox.Text;



            var updatePatient = new Patient
            {
                PatientID = id,
                nomPat = nom,
                prenomPat = prenom,
                sexe = sexe,
                adrPat = adr,



            };


            PatientService patientService = new PatientService(new GestionCabinetContext());
            patientService.UpdatePatient(updatePatient);
            FormPatient_Load(sender, e);*/
            UpdatePat update = new UpdatePat();
            update.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*PatientService p = new PatientService(new GestionCabinetContext());
            int id = int.Parse(patientIDTextBox.Text);
            p.DeletePatient(id);
            FormPatient_Load(sender, e);*/
            DeletePat pat = new DeletePat();
            pat.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void patientsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void patientsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void patientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddPat add = new AddPat();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePat update = new UpdatePat();
            update.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DeletePat pat = new DeletePat();
            pat.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
