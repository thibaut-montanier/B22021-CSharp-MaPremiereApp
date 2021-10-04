using MaPremiereApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Services {
    public class PersonneHelper {


        public SaisieUtilisateurHelper saisieUtilisateur = new SaisieUtilisateurHelper();

        public Personne CreerPersonne() {
            Personne p = new Personne();

            // demander du nom
            p.Prenom = saisieUtilisateur.DemandeString("Quel est ton prénom ?");
            // demander l'age
            p.Age = saisieUtilisateur.DemandeEntier("Quel est ton age en numérique ?");

            return p;

        }



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
