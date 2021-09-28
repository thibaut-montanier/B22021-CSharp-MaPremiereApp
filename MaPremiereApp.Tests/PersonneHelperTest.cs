using System;
using System.Collections.Generic;
using System.Text;
using MaPremiereApp;
using NUnit.Framework;

namespace MaPremiereApp.Tests {
    class PersonneHelperTest {



        [Test]
        public void DemandeStringTest() {
            SaisieUtilisateurHelper mkSaisie = new MockSaisieUtilisateurHelper();

            string result = mkSaisie.DemandeString("c'est quoi ton prenom ?");
            Assert.AreEqual("Pierre", result);
            
        }
        [Test]
        public void CreerPersonneTest() {
            PersonneHelper.saisieUtilisateur = new MockSaisieUtilisateurHelper();
            Personne result = PersonneHelper.CreerPersonne();
            Assert.AreEqual("Pierre", result.Prenom);   
        }
    }
}
