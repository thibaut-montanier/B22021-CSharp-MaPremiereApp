using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp {
    class SaisieUtilisateurHelper {
        /// <summary>
        /// Demande à l'utilisateur un entier
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int DemandeEntier(string message) {
            bool monTexteEstEntier = false;
            int age = 0;

            while (monTexteEstEntier == false) {
                Console.WriteLine(message);
                string monTexte = Console.ReadLine();
                monTexteEstEntier = int.TryParse(monTexte, out age);
            }

            return age;
        }

        // Demande à l'utilisateur une chaine de caractère
        public static string DemandeString(string message) {
            Console.WriteLine(message);
            return Console.ReadLine();

        }

    }
}
