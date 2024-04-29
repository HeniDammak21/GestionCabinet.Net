using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AuthentificationService
    {
        private readonly GestionCabinetContext _context;

        public AuthentificationService(GestionCabinetContext context)
        {
            _context = context;
        }

        public bool EstConnexionValide(string nomUtilisateur, string motDePasse)
        {
            // Rechercher l'administrateur dans la base de données
            var administrateur = _context.Administrateurs.FirstOrDefault(a => a.UserName == nomUtilisateur && a.MotDePasse == motDePasse);
            // Vérifier si l'administrateur a été trouvé et si le mot de passe correspond
            return administrateur != null;
        }
    }
}
