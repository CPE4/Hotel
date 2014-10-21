using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHotel
{
    /// <summary>
    /// Cette classe hérite de la classe utilisateur et possède des attribues propres
    /// </summary>
    class Abonne : Utilisateur
    {
        public string ABO_PSEUDO { get; set; }
        public float ABO_LATITUDE { get; set; }
        public float ABO_LONGITUDE { get; set; }
        public int IND_INDICATIF { get; set; }
        public string ABO_TEL { get; set; }
        public string ABO_AEROPORT { get; set; }
        
    }
}
