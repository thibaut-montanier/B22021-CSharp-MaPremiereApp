using System;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {

            // demander le prénom
            Console.WriteLine("Quel est ton prénom ?");
            string prenom;
            prenom = Console.ReadLine();
            // demander l'age
            Console.WriteLine("Quel est ton age ?");
            string age;
            age = Console.ReadLine();
            // afficher le message
            string messageAAfficher;
            // création du message
            messageAAfficher = CreerMessage(prenom, age);
            //affichage
            Console.WriteLine(messageAAfficher);



            string monTexte = "totot";
            bool monTexteEstEntier = false;
            int maValeur;

            monTexteEstEntier = int.TryParse(monTexte, out maValeur);
            // ici : 
            // monTexteEstEntier vaut true si monTexte est un entier, false sinon
            // maValeur : conversion de monTexte en valeur entière
            
            
        }

        public static string CreerMessage(string firstName, string agePers) {
            string message = "";
            if (agePers == "0") {
                message="Bonjour " + firstName + ", tu es un bébé";
            } else if (agePers == "1") {
                message = "Bonjour " + firstName + ", tu as 1 an.";
            } else {
                message = "Bonjour " + firstName + ", tu as " + agePers + " ans.";
            }
            return message;
        }
        public static int additionne(int nb1, int nb2) {
            
            return 0;
        }
    }
}
