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

    }
}
