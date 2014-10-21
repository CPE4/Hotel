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
    public partial class Inscription : Form
    {
        private string _userType;

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
            {
                HotelierMode();
            }
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
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Construction du JSON
            /*Resto restaurant = new Resto();
            restaurant.RES_NOM = this.AddNom.Text;
            restaurant.PRX_PRIX = this.AddPrix.Text;
            restaurant.RES_DESCRIPTION = this.AddDesc.Text;
            restaurant.RES_CATEGORIEPRIX = this.AddCatPrix.Text;
            restaurant.res_adr = this.AddRue.Text;
            restaurant.RES_CP = this.AddCodePostal.Text;
            restaurant.RES_VILLE = this.AddVille.Text;
            restaurant.RES_PAYS = this.AddPays.Text;
            restaurant.IND_INDICATIF = Convert.ToInt16(this.AddIndPays.Text);
            restaurant.RES_TEL = this.AddPhone.Text;
            restaurant.RES_MEL = this.AddEmail.Text;
            restaurant.RES_SITEWEB = this.AddWeb.Text;

            String json = JsonConvert.SerializeObject(restaurant);

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

            response.Close();*/
        }
    }
}
