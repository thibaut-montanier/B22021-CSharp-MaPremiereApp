using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp {
    class PersonneHelper {


        public static Personne CreerPersonne() {
            Personne p = new Personne();

            // demander du nom
            p.Prenom = SaisieUtilisateurHelper.DemandeString("Quel est ton prénom ?");
            // demander l'age
            p.Age = SaisieUtilisateurHelper.DemandeEntier("Quel est ton age en numérique ?");

            return p;

        }



        public static string CreerMessage(Personne p) {
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
