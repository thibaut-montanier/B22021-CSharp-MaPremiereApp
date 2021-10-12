using MaPremiereApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Tests {
    public class MockSaisieUtilisateurHelper : SaisieUtilisateurHelper {

        public override int DemandeEntier(string message) {
            return 5;
        }

        public override string DemandeString(string message) {
            return "Pierre";
        }
    }
}
