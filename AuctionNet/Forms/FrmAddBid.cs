using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionNet.Controllers;
using AuctionNet.Interfaces;

namespace AuctionNet.Forms
{
    public partial class FrmAddBid : Form
    {
        private IBidController _bidController;
        public FrmAddBid()
        {
            _bidController = new BidController();
            InitializeComponent();
        }
        private void btnAddBid_Click(object sender, EventArgs e)
        {
            var bid = new Bids()
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                AuctionId = int.Parse(txtAuctionId.Text),
                Bid = int.Parse(txtBid.Text),
                Date = DateTime.Now
                
            };

            var result = _bidController.Create(bid);

            if (result.Count > 0)
            {
                MessageBox.Show("Budet gick inte att lägga");
            }
            else
            {
                MessageBox.Show("Budet är lagt");
            }
        }

        private void FrmAddBid_Load(object sender, EventArgs e)
        {

        }
    }
}
