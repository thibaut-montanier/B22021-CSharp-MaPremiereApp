using System;
using System.Collections.Generic;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {

            // Déclaration de ma liste
            List<Personne> lesPersonnes = new List<Personne>();
            PersonneHelper persHelper = new PersonneHelper();
            // menu de saisie
            bool exit = false;
            while (exit == false) {
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("1. Creer une nouvelle personne");
                Console.WriteLine("2. Afficher les personnes");
                Console.WriteLine("3. Quitter");
                string choixUtilisateur = Console.ReadLine();
                if (choixUtilisateur == "1") {
                    Personne p1 = persHelper.CreerPersonne();
                    lesPersonnes.Add(p1);
                } else if (choixUtilisateur == "2") {
                    int sumAge = 0;
                    foreach (Personne p in lesPersonnes) {
                        sumAge = sumAge + p.Age;
                        string messageAAfficher = persHelper.CreerMessage(p);
                        //affichage
                        Console.WriteLine(messageAAfficher);
                    }
                    int moyenne = sumAge / lesPersonnes.Count;
                    Console.WriteLine("La moyenne d'age est : " + moyenne);
                } else if (choixUtilisateur == "3") {
                    exit = true;
                    Console.WriteLine("Appuyer sur une touche pour quitter");
                    Console.ReadKey();
                }
            }

        }

        
    }
}
