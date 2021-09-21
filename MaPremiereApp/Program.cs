using System;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {

            // demander le prénoms
            Personne p = new Personne();
            
            // demander du nom
            p.Prenom = DemandeString("Quel est ton prénom ?");
            // demander l'age
            p.Age = DemandeEntier("Quel est ton age en numérique ?");
            
            // création dbu message
            string messageAAfficher = CreerMessage(p);
            //affichage
            Console.WriteLine(messageAAfficher);
            
            Console.WriteLine("Appuyer sur une touche pour quitter");
            Console.ReadKey();
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
