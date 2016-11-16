using AuctionNet.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionNet
{
//Frågan: Vilka auk-oner avslutas under e5 visst datumintervall? Samt vad blir
//provisionen för varje auk-on inom det intervallet?
//kanske kan vara på samma knapp som visa auktioner, så kan man kanske 
//filtrera på datum där.
    public partial class FrmAuctionNetStartPage : Form
    {
        public FrmAuctionNetStartPage()
        {
            InitializeComponent();
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.Show();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            FrmAddSupplier frmAddSupplier = new FrmAddSupplier();
            frmAddSupplier.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.Show();
        }

        private void btnAddAuction_Click(object sender, EventArgs e)
        {
            FrmAddAuctin frmAddAuction = new FrmAddAuctin();
            frmAddAuction.Show();
        }

        private void btnAddBid_Click(object sender, EventArgs e)
        {
            FrmAddBid frmAddBid = new FrmAddBid();
            frmAddBid.Show();
        }
    }
}
