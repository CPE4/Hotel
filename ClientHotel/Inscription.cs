using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
        private bool DEBUG = true;
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
            lblUrl.Visible = DEBUG;
            txtUrl.Visible = DEBUG;
            lblTypeUtilisateur.Visible = DEBUG;
            cbxTypeUtilisateur.Visible = DEBUG;
            if (DEBUG)
            {
                txtUrl.Text = "http://localhost:1597/api/";
                cbxTypeUtilisateur.Items.Add("Hotelier");
                cbxTypeUtilisateur.Items.Add("Abonne");
            }
        }

        public Inscription(string typeUtilisateur)
        {
            UserType = typeUtilisateur;
            InitializeComponent();
            lblUrl.Visible = DEBUG;
            txtUrl.Visible = DEBUG;
            lblTypeUtilisateur.Visible = DEBUG;
            cbxTypeUtilisateur.Visible = DEBUG;
            if (DEBUG)
            {
                txtUrl.Text = "http://localhost:1597/api/";
                cbxTypeUtilisateur.Items.Add("Hotelier");
                cbxTypeUtilisateur.Items.Add("Abonne");
            }
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
            TypeUtilsateurP = TypeUtilisateur.Hotelier;
            actualiserListePays();
            FabriqueUtilisateurP = new FabriqueUtilisateur();
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
            TypeUtilsateurP = TypeUtilisateur.Abonne;
            actualiserListePays();
            FabriqueUtilisateurP = new FabriqueUtilisateur();
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
            UtilisateurP.MOTDEPASSE = this.txtMdp.Text;
            UtilisateurP.MEL = this.txtMail.Text;
            UtilisateurP.NOM = this.txtNom.Text;
            UtilisateurP.PRENOM = this.txtPrenom.Text;
            UtilisateurP.ADRLIGNE1 = this.txtAdresse.Text;
            UtilisateurP.ADRLIGNE2 = this.txtAdresseSuite.Text;
            UtilisateurP.CP = this.txtCP.Text;
            UtilisateurP.VILLE = this.txtVille.Text;
            UtilisateurP.ETAT = this.txtEtat.Text;
            UtilisateurP.PAY_ID = this.cbxPays.SelectedIndex;
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
            if (DEBUG)
                Utils.sendDataToApi(txtUrl + UtilisateurP.Path, json);
            else
                Utils.sendDataToApi("http://localhost:1597/api/" + UtilisateurP.Path, json);
        }

        /// <summary>
        /// convertit la chaine en float, si la chaine possède un . il sera remplacé par une ,
        /// </summary>
        /// <param name="str">un chaine de caractère</param>
        /// <returns>un float</returns>
        public float convertStringToFloat(string str)
        {
            if (str.Contains("."))
                str = str.Replace(".", ",");
            return System.Convert.ToSingle(str);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxTypeUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTypeUtilisateur.Text == "Hotelier")
                HotelierMode();
            else
                AbonneMode();
        }

        private void actualiserListePays()
        {
            /*string data = Utils.getDataFromApi("http://localhost:1597/api/Restaurant/", "json");
            List<Pays> listPays = JsonConvert.DeserializeObject<Restaurant>(data);*/
            /*  
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("Id", System.Type.GetType("System.Int16"));
            dt.Columns.Add(col1);
            DataColumn col2 = new DataColumn("Nom", System.Type.GetType("System.String"));
            dt.Columns.Add(col2);
            dt = JsonConvert.DeserializeObject<DataTable>(new DataTableConverter());
            */
            try
            {
                string data;
                if (DEBUG)
                    data = Utils.getDataFromApi(txtUrl.Text + "Pays", "JSON");
                else
                    data = Utils.getDataFromApi("http://localhost:1597/api/Pays", "Json");
                List<Pays> listPays = JsonConvert.DeserializeObject<List<Pays>>(data);
                foreach (Pays pays in listPays)
                {
                    cbxPays.Items.Add(new ComboboxItem(pays.Id, pays.Nom));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
