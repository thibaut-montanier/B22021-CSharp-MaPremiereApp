using System;
using System.Collections.Generic;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {
            // demander du nom

            // menu de saisie
            Console.WriteLine("Que voulez vous faire ?");
            Console.WriteLine("1. Creer une nouvelle personne");
            Console.WriteLine("2. Afficher les personnes");
            Console.WriteLine("3. Quitter");
            string choixUtilisateur = Console.ReadLine();






            // 1. Instanciation de ma liste
            List<Personne> lP = new List<Personne>();
            // ajout d'une personne à la liste
            Personne p2 = new Personne();
            p2.Prenom = "Pierre";
            p2.Age = 25;
            lP.Add(p2);
            // comptage
            int nb= lP.Count;

            // parcours
            foreach(Personne pIterateur in lP) {

            }


            // créer la personne

            Personne p = CreerPersonne();
            
            // création dbu message
            string messageAAfficher = CreerMessage(p);
            //affichage
            Console.WriteLine(messageAAfficher);
            
            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();
        }




        public static Personne CreerPersonne() {
            Personne p = new Personne();

            // demander du nom
            p.Prenom = DemandeString("Quel est ton prénom ?");
            // demander l'age
            p.Age = DemandeEntier("Quel est ton age en numérique ?");

            return p;

        }

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

        public static string DemandeString(string message) {
            Console.WriteLine(message);
            return Console.ReadLine();
            
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
        public static int additionne(int nb1, int nb2) {

            return 0;
        }
    }
}
