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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void administrateursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.administrateursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestionCabinetDataSet);

        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionCabinetDataSet.Administrateurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.administrateursTableAdapter.Fill(this.gestionCabinetDataSet.Administrateurs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = userNameTextBox.Text;
            string motDePasse = motDePasseTextBox.Text;

            // Créer une instance du service d'authentification en passant le contexte de la base de données
            var authentificationService = new AuthentificationService(new GestionCabinetContext());
            // Vérifier si les informations d'identification sont valides en utilisant le service d'authentification
            if (authentificationService.EstConnexionValide(nomUtilisateur, motDePasse))
            {
                // Si les informations d'identification sont valides, ouvrez FormPrincipale
                FormConsultation formPrincipale = new FormConsultation();
                formPrincipale.Show();

                // Masquer le formulaire de connexion
                this.Hide();
            }
            else
            {
                // Afficher un message d'erreur si les informations d'identification sont incorrectes
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
