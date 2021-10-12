using MaPremiereApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Services {
    public  class FamilleHelper {
        #region Champs privés
        public List<Famille> _lesFamilles = new List<Famille>();
        #endregion


        #region Gestion des dépendances
        private SaisieUtilisateurHelper saisieUtilisateur;
        public FamilleHelper(SaisieUtilisateurHelper saisieUtilisateur) {
            this.saisieUtilisateur = saisieUtilisateur;
        }

        #endregion
        /// <summary>
        /// Permet de créer une famille en demandant les informations nécessaires à l'utilisateur
        /// </summary>
        /// <returns>Une nouvelle famille</returns>
        public virtual Famille CreerFamille() {
            Famille famille = new Famille();
            famille.Nom = saisieUtilisateur.DemandeString("Nom de la famille ?");

            famille.Membres = new List<Personne>();
            _lesFamilles.Add(famille);
            return famille;
        }

        public virtual void AfficherLesFamilles() {
            // affichage des familles et de leurs membres
            saisieUtilisateur.AfficheMessage(genereMessageLesFamilles());
        }

        public string genereMessageLesFamilles() {
            // affichage des familles et de leurs membres
            List<string> lesMessagesFamille = new List<string>();
            foreach (Famille uneFamille in _lesFamilles) {
                List<string> PrenomDesMembres = new List<string>();
                foreach (Personne p in uneFamille.Membres) {
                    PrenomDesMembres.Add(p.Prenom);
                }
                lesMessagesFamille.Add("La famille " + uneFamille.Nom + " contient " + uneFamille.Membres.Count + " membre(s) : " + String.Join(", ", PrenomDesMembres));
            }
            return String.Join("\n", lesMessagesFamille);
        }



        public virtual Famille DemandeFamille() {

            // on boucle sur la demande de la famille : elle doit exister
            while (true) {
                string NomDeLaFamille = saisieUtilisateur.DemandeString("Nom de la famille ?");
                foreach (var f in _lesFamilles) {
                    if (f.Nom == NomDeLaFamille) {
                        return f;
                    }
                }
                Console.WriteLine("La famille n'existe pas");
            }
        }
    }
}
