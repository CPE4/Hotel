using Newtonsoft.Json;
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
    public partial class Connexion : Form
    {
        #region CTR
        public Connexion()
        {
            InitializeComponent();
        }

        #endregion
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtMdp.Text != "" && txtNom.Text != "" && txtPrenom.Text != "")
            {
                string json = "{\"nom\":\"" + txtNom.Text + "\",\"prenom\":\"" + txtPrenom.Text + "\",\"mdp\":\"" + txtMdp.Text + "\"}";
                Utils.sendDataToApi("http://localhost:1597/api/Connexion", json);

            }
            else
            {
                MessageBox.Show("Remplissez tous les champs");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void etablieConnexion()
        {
            /*
            utilisateur = new Utilisateur();
            btnConnexion.Visible = false;
            btnInscription.Visible = false;
             * */
        }
    }
}
