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
    public partial class HotelForm : Form
    {
        private Hotel _hotel;
        public string defaultURL;

        public HotelForm(string url)
        {
            InitializeComponent();
            this._hotel = new Hotel();
            if (url == "")
            {
                defaultURL = "http://localhost:1597/api/";
            }
            else
            {
                defaultURL = url;
            }
            this.actualiserListePays();
            this.actualiserListePrix();
        }

        private void BUT_Ok_Click(object sender, EventArgs e)
        {
            // Construction du JSON
            this._hotel.HOT_Nom = this.HOT_Nom.Text;
            this._hotel.HOT_Description = this.HOT_Description.Text;
            this._hotel.HOT_AdrLigne1 = this.HOT_AdrLigne1.Text;
            this._hotel.HOT_AdrLigne2 = this.HOT_AdrLigne2.Text;
            this._hotel.HOT_CP = this.HOT_CP.Text;
            this._hotel.HOT_Ville = this.HOT_Ville.Text;
            this._hotel.HOT_Etat = this.HOT_Etat.Text;
            this._hotel.PAY_ID = 0;// TODO this.PAY_ID.Text;
            this._hotel.HOT_Latitude = (float)Convert.ToDouble(this.HOT_Latitude.Text);
            this._hotel.HOT_Longitude = (float)Convert.ToDouble(this.HOT_Longitude.Text);
            this._hotel.IND_Indicatif = Convert.ToInt32(this.IND_Indicatif.Text);
            this._hotel.CAT_NbEtoiles = Convert.ToInt32(this.CAT_NbEtoiles.Text);
            this._hotel.HOT_Tel = this.HOT_Tel.Text;
            this._hotel.HOT_Mel = this.HOT_Mel.Text;
            this._hotel.HOT_SiteWeb = this.HOT_SiteWeb.Text;
            this._hotel.HOT_NbChambres = Convert.ToInt32(this.HOT_NbChambres.Text);

            String json = JsonConvert.SerializeObject(this._hotel);

            Utils.sendDataToApi(defaultURL+"Hotel", json);
        }

        private void actualiserListePrix()
        {
            try
            {
                string data = Utils.getDataFromApi(defaultURL+"FourchettePrix", "Json");
                List<FourchettePrix> listPays = JsonConvert.DeserializeObject<List<FourchettePrix>>(data);
                foreach (FourchettePrix fPrix in listPays)
                {
                    this.HOT_Prix.Items.Add(new ComboboxItem(fPrix.PRX_ID, fPrix.PRX_Fourchette));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void actualiserListePays()
        {
            try
            {
                string data = Utils.getDataFromApi(defaultURL + "Pays", "Json");
                List<Pays> listPays = JsonConvert.DeserializeObject<List<Pays>>(data);
                foreach (Pays pays in listPays)
                {
                    this.HOT_Pays.Items.Add(new ComboboxItem(pays.Id, pays.Nom));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
