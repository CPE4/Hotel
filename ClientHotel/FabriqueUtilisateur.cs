using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHotel
{
    class FabriqueUtilisateur
    {
        public Utilisateur creation(TypeUtilisateur type)
        {
            Utilisateur utilisateur;
            switch (type)
            {
                case TypeUtilisateur.Hotelier:
                    utilisateur = new Hotelier();
                    break;
                case TypeUtilisateur.Abonne:
                    utilisateur = new Abonne();
                    break;
                default:
                    utilisateur = new Utilisateur();
                    break;
            }
            return utilisateur;
        }
    }
}
