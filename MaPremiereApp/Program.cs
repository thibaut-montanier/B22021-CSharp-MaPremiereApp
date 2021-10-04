using MaPremiereApp.Model;
using MaPremiereApp.Services;
using System;
using System.Collections.Generic;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {


            /// 1. Creer une famille
            Famille uneFamille = new Famille();
            uneFamille.Nom = "Dupond";
            uneFamille.Membres = new List<Personne>();
            /// 2. Créer une personnes
            /// 2.1 Créer la personne
            Personne pers = new Personne();
            pers.Prenom = "Jean";
            pers.Age = 7;
            /// 2.2 Faire le lien avec la famille
            pers.Famille = uneFamille;
            pers.Famille.Membres.Add(pers);

            // Bonjour Jean Dupond, tu as 5 ans
            Console.WriteLine("Bonjour " + pers.Prenom + pers.Famille.Nom + ", tu as " + pers.Age);
            Console.WriteLine("La famille Dupond contient " + uneFamille.Membres.Count + " membre(s) : Jean");














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
