using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHotel
{
    /// <summary>
    /// Cette classe défini les attribues que possèdent tous les types d'utilisateurs
    /// </summary>
    class Utilisateur
    {
        public string Path { get; set; }
        public int ID { get; set; }
        public string MOTDEPASSE { get; set; }
        public string MEL { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string ADRLIGNE1 { get; set; }
        public string ADRLIGNE2 { get; set; }
        public string CP { get; set; }
        public string VILLE { get; set; }
        public string ETAT { get; set; }
        public int PAY_ID { get; set; }
    }
}
