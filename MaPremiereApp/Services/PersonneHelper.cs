using MaPremiereApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Services {
     class PersonneHelper {
        
        
        private List<Personne> lesPersonnes = new List<Personne>();

        private SaisieUtilisateurHelper saisieUtilisateur ;
        private FamilleHelper familleHelper;
        public PersonneHelper(SaisieUtilisateurHelper saisieUtilisateur, FamilleHelper familleHelper) {
            this.saisieUtilisateur = saisieUtilisateur;
            this.familleHelper = familleHelper;
        }

        /// <summary>
        /// Création de la personne
        /// </summary>
        /// <returns>Personne qui a été créée</returns>
        public Personne CreerPersonne() {
            Personne p = new Personne();

            // demander du nom
            p.Prenom = saisieUtilisateur.DemandeString("Quel est ton prénom ?");
            // demander l'age
            p.Age = saisieUtilisateur.DemandeEntier("Quel est ton age en numérique ?");
            p.Famille = familleHelper.DemandeFamille();
            // ajout de la personne en tant que membre de sa famille
            p.Famille.Membres.Add(p);

            lesPersonnes.Add(p);

            return p;

        }

        /// <summary>
        /// Affichage de la liste des personnes
        /// </summary>
        public void AfficherLesPersonnes() {
            int sumAge = 0;
            foreach (Personne p in lesPersonnes) {
                sumAge = sumAge + p.Age;
                string messageAAfficher = CreerMessage(p);
                //affichage
                Console.WriteLine(messageAAfficher);
            }
            if (lesPersonnes.Count > 0) {
                int moyenne = sumAge / lesPersonnes.Count;
                Console.WriteLine("La moyenne d'age est : " + moyenne);
            }
            
        }

        /// <summary>
        /// Création d'un message pour afficher une personne
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string CreerMessage(Personne p) {
            string message = "";
            if (p.Age == 0) {
                message = "Bonjour " + p.Prenom + ", tu es un bébé";
            } else if (p.Age == 1) {
                message = "Bonjour " + p.Prenom + ", tu as 1 an.";
            } else {
                message = "Bonjour " + p.Prenom + ", tu as " + p.Age + " ans.";
            }
            return message;
        }

    }
}
