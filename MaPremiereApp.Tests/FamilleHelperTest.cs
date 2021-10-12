using MaPremiereApp.Model;
using MaPremiereApp.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaPremiereApp.Tests {
    class FamilleHelperTest {
        FamilleHelper familleHelper;
        Mock<SaisieUtilisateurHelper> mockSaisie;
        [SetUp]
        public void Setup() {
            // gestion du mock sur la saisie utilisateur
            mockSaisie = new Mock<SaisieUtilisateurHelper>();
            mockSaisie.Setup(m => m.DemandeString("Nom de la famille ?"))
                    .Returns(() => "Polo");
            SaisieUtilisateurHelper saisieUtilisateur = mockSaisie.Object;
            // création de la classe à tester
            familleHelper = new FamilleHelper(saisieUtilisateur);
        }
        [Test]
        public void CreerFamilleTest() {
            Famille result = familleHelper.CreerFamille();
            Assert.AreEqual("Polo", result.Nom);
            mockSaisie.Verify(m => m.DemandeString(It.IsAny<string>()), Times.Once);
        }
    }
}
