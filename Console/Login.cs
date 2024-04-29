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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = textBoxUsername.Text;
            string motDePasse = textBoxPass.Text;

            // Créer une instance du service d'authentification en passant le contexte de la base de données
            var authentificationService = new AuthentificationService(new GestionCabinetContext());
            // Vérifier si les informations d'identification sont valides en utilisant le service d'authentification
            if (authentificationService.EstConnexionValide(nomUtilisateur, motDePasse))
            {
                // Si les informations d'identification sont valides, ouvrez FormPrincipale
                Home formPrincipale = new Home();
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


        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}