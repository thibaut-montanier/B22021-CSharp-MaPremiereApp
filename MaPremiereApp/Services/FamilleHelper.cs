using MaPremiereApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Services {
    public class FamilleHelper {
        SaisieUtilisateurHelper saisieUtilisateur = new SaisieUtilisateurHelper();

        /// <summary>
        /// Permet de créer une famille en demandant les informations nécessaires à l'utilisateur
        /// </summary>
        /// <returns>Une nouvelle famille</returns>
        public Famille CreerFamille() {
            Famille result = new Famille();
            result.Nom = saisieUtilisateur.DemandeString("Nom de la famille ?");

            return result;
        }
    }
}
