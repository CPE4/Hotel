using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHotel
{
    class Hotel
    {
        public int HOT_ID { get; set; }
        public int HTR_ID { get; set; }
        public int PRX_ID { get; set; }
        public string HOT_Nom { get; set; }
        public string HOT_Description { get; set; }
        public string HOT_AdrLigne1 { get; set; }
        public string HOT_AdrLigne2 { get; set; }
        public string HOT_CP { get; set; }
        public string HOT_Ville { get; set; }
        public string HOT_Etat { get; set; }
        public int PAY_ID { get; set; }
        public float HOT_Latitude { get; set; }
        public float HOT_Longitude { get; set; }
        public int IND_Indicatif { get; set; }
        public int CAT_NbEtoiles { get; set; }
        public string HOT_Tel { get; set; }
        public string HOT_Mel { get; set; }
        public string HOT_SiteWeb { get; set; }
        public int HOT_NbChambres { get; set; }
    }
}
