using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApp.Model {
    public class Personne {

        public Famille Famille { get; set; }
        public int ID { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
    }
}
