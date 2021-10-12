using System;
using System.Collections.Generic;
using System.Text;
using MaPremiereApp;
using MaPremiereApp.Model;
using MaPremiereApp.Services;
using NUnit.Framework;

namespace MaPremiereApp.Tests {
    class PersonneHelperTest {



        [Test]
        public void DemandeStringTest() {
            SaisieUtilisateurHelper mkSaisie = new MockSaisieUtilisateurHelper();

            string result = mkSaisie.DemandeString("c'est quoi ton prenom ?");
            Assert.AreEqual("Pierre", result);
            
        }
        //[Test]
        //public void CreerFamilleTest() {
            
        //    Famille result = familleHelper.CreerFamille();
        //    Assert.AreEqual("Dupond", result.Nom);   
        //}

        //[Test]
        //public void CreerPersonneTest() {

        //    Personne result = personneHelper.CreerPersonne();
        //    Assert.AreEqual("Jean", result.Prenom);
        //    Assert.AreEqual("Dupond", result.Famille.Nom);
        //}
    }
}
