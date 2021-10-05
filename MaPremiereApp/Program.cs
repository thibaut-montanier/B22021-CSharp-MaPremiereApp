using MaPremiereApp.Model;
using MaPremiereApp.Services;
using System;
using System.Collections.Generic;

namespace MaPremiereApp {
    class Program {
        static void Main(string[] args) {
            // Déclaration de ma liste
            SaisieUtilisateurHelper saisieHelper = new SaisieUtilisateurHelper();
            FamilleHelper famHelper = new FamilleHelper();
            PersonneHelper persHelper = new PersonneHelper(saisieHelper, famHelper) ;
            
            // menu de saisie
            bool exit = false;
            while (exit == false) {

                string MsgMenu = "Que voulez vous faire ?\n" +
                                    "1. Creer une nouvelle personne\n" +
                                    "2. Afficher les personnes\n" +
                                    "3. Créer une famille\n" +
                                    "4. Afficher les familles\n" +
                                    "Q. Quitter";
                string choixUtilisateur = saisieHelper.DemandeString(MsgMenu);

                if (choixUtilisateur == "1") {
                    persHelper.CreerPersonne();
                } else if (choixUtilisateur == "2") {
                    persHelper.AfficherLesPersonnes();
                } else if (choixUtilisateur == "3") {
                    // créer une famille
                    famHelper.CreerFamille();
                } else if (choixUtilisateur == "4") {
                    famHelper.AfficherLesFamilles();
                } else if (choixUtilisateur == "Q") {
                    exit = true;
                    Console.WriteLine("Appuyer sur une touche pour quitter");
                    Console.ReadKey();
                }
            }

        }


    }
}
