using System;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {

            // demander le prénom
            
            string prenom = DemandeString("Quel est ton prénom ?");
            // demander l'age
            
            int age = DemandeEntier("Quel est ton age en numérique ?");
            // afficher le message
            string messageAAfficher;
            // création dbu message
            messageAAfficher = CreerMessage(prenom, age);
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


        public static string CreerMessage(string firstName, int age) {
            string message = "";
            if (age == 0) {
                message = "Bonjour " + firstName + ", tu es un bébé";
            } else if (age == 1) {
                message = "Bonjour " + firstName + ", tu as 1 an.";
            } else {
                message = "Bonjour " + firstName + ", tu as " + age + " ans.";
            }
            return message;
        }
        public static int additionne(int nb1, int nb2) {

            return 0;
        }
    }
}
