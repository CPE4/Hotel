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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.ShowDialog();
        }
    }
}
