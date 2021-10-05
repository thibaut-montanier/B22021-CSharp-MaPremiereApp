using MaPremiereApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Services {
    public class FamilleHelper {
        SaisieUtilisateurHelper saisieUtilisateur = new SaisieUtilisateurHelper();
        List<Famille> lesFamilles = new List<Famille>();
        /// <summary>
        /// Permet de créer une famille en demandant les informations nécessaires à l'utilisateur
        /// </summary>
        /// <returns>Une nouvelle famille</returns>
        public Famille CreerFamille() {
            Famille famille = new Famille();
            famille.Nom = saisieUtilisateur.DemandeString("Nom de la famille ?");

            famille.Membres = new List<Personne>();
            lesFamilles.Add(famille);
            return famille;
        }

        public void AfficherLesFamilles() {
            // affichage des familles et de leurs membres
            foreach (Famille uneFamille in lesFamilles) {
                List<string> PrenomDesMembres = new List<string>();
                foreach (Personne p in uneFamille.Membres) {
                    PrenomDesMembres.Add(p.Prenom);
                }
                Console.WriteLine("La famille " + uneFamille.Nom + " contient " + uneFamille.Membres.Count + " membre(s) : " + String.Join(", ", PrenomDesMembres));

            }
        }

        public Famille DemandeFamille() {

            // on boucle sur la demande de la famille : elle doit exister
            while (true) {
                string NomDeLaFamille = saisieUtilisateur.DemandeString("Nom de la famille ?");
                foreach (var f in lesFamilles) {
                    if (f.Nom == NomDeLaFamille) {
                        return f;
                    }
                }
                Console.WriteLine("La famille n'existe pas");
            }
        }
    }
}
