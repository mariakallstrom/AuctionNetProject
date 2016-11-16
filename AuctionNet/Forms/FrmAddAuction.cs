using AuctionNet.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionNet.Forms
{
    public partial class FrmAddAuction : Form
    {
        public FrmAddAuction()
        {
            InitializeComponent();
            FormAddAuc = this;

        }

        public static FrmAddAuction FormAddAuc;
        private void FrmAddAuction_Load(object sender, EventArgs e)
        {

        }
    }
}
