using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHotel
{
    public enum TypeUtilisateur { Hotelier, Abonne };

    public partial class Inscription : Form
    {
        private string _userType;
        private FabriqueUtilisateur _fabriqueUtilisateur;
        private Utilisateur _utilisateur;
        private TypeUtilisateur _typeUtilsateur;

        public TypeUtilisateur TypeUtilsateurP
        {
            get { return _typeUtilsateur; }
            set { _typeUtilsateur = value; }
        }

        internal Utilisateur UtilisateurP
        {
            get { return _utilisateur; }
            set { _utilisateur = value; }
        }

        internal FabriqueUtilisateur FabriqueUtilisateurP
        {
            get { return _fabriqueUtilisateur; }
            set { _fabriqueUtilisateur = value; }
        }

        public string UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }
        public Inscription()
        {
            InitializeComponent();
        }

        public Inscription(string typeUtilisateur)
        {
            UserType = typeUtilisateur;
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            if (UserType == "Hotelier")
                HotelierMode();
            else
                AbonneMode();

        }

        private void HotelierMode()
        {
                lblPseudo.Visible = false;
                txtPseudo.Visible = false;
                lblLongitude.Visible = false;
                txtLongitude.Visible = false;
                lblLatitude.Visible = false;
                txtLatitude.Visible = false;
                lblTel.Visible = false;
                listInd.Visible = false;
                txtTel.Visible = false;
                lblPays.Visible = false;
                listPays.Visible = false;
                TypeUtilsateurP = TypeUtilisateur.Hotelier;
                UtilisateurP = FabriqueUtilisateurP.creation(TypeUtilisateur.Hotelier);
        }

        private void AbonneMode()
        {
            lblPseudo.Visible = true;
            txtPseudo.Visible = true;
            lblLongitude.Visible = true;
            txtLongitude.Visible = true;
            lblLatitude.Visible = true;
            txtLatitude.Visible = true;
            lblTel.Visible = true;
            listInd.Visible = true;
            txtTel.Visible = true;
            lblPays.Visible = true;
            listPays.Visible = true;
            TypeUtilsateurP = TypeUtilisateur.Abonne;
            UtilisateurP = FabriqueUtilisateurP.creation(TypeUtilisateur.Abonne);
        }

        /// <summary>
        /// Création d'un utilisateur(hotelier ou abonne) puis l'envoie au format JSON au serveur via une requette http
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Construction du JSON
            UtilisateurP.MOTDEPASSE  = this.txtMdp.Text;
            UtilisateurP.MEL = this.txtMail.Text;
            UtilisateurP.NOM = this.txtNom.Text;
            UtilisateurP.PRENOM = this.txtPrenom.Text;
            UtilisateurP.ADRLIGNE1 = this.txtAdresse.Text;
            UtilisateurP.ADRLIGNE2 = this.txtAdresseSuite.Text;
            UtilisateurP.CP = this.txtCP.Text;
            UtilisateurP.VILLE = this.txtVille.Text;
            UtilisateurP.ETAT = this.txtEtat.Text;
            UtilisateurP.PAY_ID = this.listPays.SelectedIndex;
            if (TypeUtilsateurP == TypeUtilisateur.Abonne)
            {
                ((Abonne)UtilisateurP).ABO_PSEUDO = this.txtPseudo.Text;
                ((Abonne)UtilisateurP).ABO_LATITUDE = convertStringToFloat(this.txtLatitude.Text);
                ((Abonne)UtilisateurP).ABO_LONGITUDE = convertStringToFloat(this.txtLongitude.Text);
                ((Abonne)UtilisateurP).IND_INDICATIF = this.listInd.SelectedIndex;
                ((Abonne)UtilisateurP).ABO_TEL = this.txtTel.Text;
                ((Abonne)UtilisateurP).ABO_AEROPORT = this.txtTel.Text;
            }

            String json = JsonConvert.SerializeObject(UtilisateurP);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:1194/api/Restaurant");
            request.Accept = "application/json";
            request.ContentType = "text/json";
            request.Method = "POST";
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            StreamWriter StreamWriter = new StreamWriter(request.GetRequestStream());
            StreamWriter.Write(json);
            StreamWriter.Flush();
            StreamWriter.Close();
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();

            response.Close();
        }

        /// <summary>
        /// convertit la chaine en float, si la chane possède un . il sera remplacé par une ,
        /// </summary>
        /// <param name="str">un chaine de caractère</param>
        /// <returns>un float</returns>
        public float convertStringToFloat(string str)
        {
            if (str.Contains("."))
                str = str.Replace(".", ",");
            return System.Convert.ToSingle(str);
        } 
    }
}
