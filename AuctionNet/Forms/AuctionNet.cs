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
            Hide();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            FrmAddSupplier frmAddSupplier = new FrmAddSupplier();
            frmAddSupplier.Show();
            Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.Show();
            Hide();
        }

        private void btnAddAuction_Click(object sender, EventArgs e)
        {
            FrmAddAuction frmAddAuction = new FrmAddAuction();
            frmAddAuction.Show();
            Hide();
        }

        private void btnAddBid_Click(object sender, EventArgs e)
        {
            FrmAddBid frmAddBid = new FrmAddBid();
            frmAddBid.Show();
            Hide();
        }

        private void btnShowAllCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomerList frmCustomerList = new FrmCustomerList();
            frmCustomerList.Show();
            Hide();
        }

        private void btnShowMonthlyCommission_Click(object sender, EventArgs e)
        {
            FrmShowCommissionPerMonth frmCommissionPerMonth = new FrmShowCommissionPerMonth();
            frmCommissionPerMonth.Show();
            Hide();
        }

        private void btnViewCurrentAuctions_Click(object sender, EventArgs e)
        {
            FrmShowAuctions frmShowAuctions = new FrmShowAuctions();
            frmShowAuctions.Show();
            Hide();
        }

        private void FrmAuctionNetStartPage_Load(object sender, EventArgs e)
        {

        }
    }
}
