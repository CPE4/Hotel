using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHotel
{
    public partial class Home : Form
    {
        private Utilisateur utilisateur;
        private const string SERVER_DEFAULT_PATH = "http://localhost:1597/api/";
    
        public Home()
        {
            InitializeComponent();
            txtServeur.Text = SERVER_DEFAULT_PATH;
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription("Hotelier");
            inscription.ShowDialog();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.ShowDialog();
            utilisateur = new Utilisateur();
            btnConnexion.Visible = false;
            btnInscription.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void ConnexionClient()
        {
            utilisateur = new Hotelier();
        }
    }
}
