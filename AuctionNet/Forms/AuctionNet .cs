using System;
using System.Windows.Forms;

namespace AuctionNet.Forms
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
            FrmAddAuction frmAddAuction = new FrmAddAuction();
            frmAddAuction.Show();
        }

        private void btnAddBid_Click(object sender, EventArgs e)
        {
            FrmAddBid frmAddBid = new FrmAddBid();
            frmAddBid.Show();
        }

        private void FrmAuctionNetStartPage_Load(object sender, EventArgs e)
        {

        }
    }
}
