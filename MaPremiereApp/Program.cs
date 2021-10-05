using MaPremiereApp.Model;
using MaPremiereApp.Services;
using System;
using System.Collections.Generic;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {


            // Déclaration de ma liste
            List<Personne> lesPersonnes = new List<Personne>();
            List<Famille> lesFamilles = new List<Famille>();
            PersonneHelper persHelper = new PersonneHelper();
            FamilleHelper famHelper = new FamilleHelper();
            SaisieUtilisateurHelper saisieHelper = new SaisieUtilisateurHelper();
            // menu de saisie
            bool exit = false;
            while (exit == false) {

                string MsgMenu = "Que voulez vous faire ?\n" +
                                    "1. Creer une nouvelle personne\n" +
                                    "2. Afficher les personnes\n" +
                                    "3. Créer une famille\n" +
                                    "4. Afficher les familles\n" +
                                    "9. Quitter";
                string choixUtilisateur = saisieHelper.DemandeString(MsgMenu);

                if (choixUtilisateur == "1") {
                    Personne p1 = persHelper.CreerPersonne();

                    // on boucle sur la demande de la famille : elle doit exister
                    while (p1.Famille == null) {
                        string NomDeLaFamille = saisieHelper.DemandeString("Nom de la famille ?");
                        foreach (var f in lesFamilles) {
                            if (f.Nom == NomDeLaFamille) {
                                p1.Famille = f;
                                break;
                            }
                        }
                        if (p1.Famille == null) {
                            Console.WriteLine("La famille n'existe pas");
                        }
                    }

                    // ajout de la personne à la liste
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
                    // créer une famille
                    Famille f = famHelper.CreerFamille();
                    lesFamilles.Add(f);
                } else if (choixUtilisateur == "4") {
                    // affichage des familles et de leurs membres
                    foreach (Famille f in lesFamilles) {
                        Console.WriteLine("Famille : " + f.Nom);
                    }

                    //List<string> PrenomDesMembres = new List<string>();
                    //foreach (Personne p in uneFamille.Membres) {
                    //    PrenomDesMembres.Add(p.Prenom);
                    //}
                    //Console.WriteLine("La famille Dupond contient " + uneFamille.Membres.Count + " membre(s) : " + String.Join(", ", PrenomDesMembres));

                } else if (choixUtilisateur == "Q") {
                    exit = true;
                    Console.WriteLine("Appuyer sur une touche pour quitter");
                    Console.ReadKey();
                }
            }

        }


    }
}
