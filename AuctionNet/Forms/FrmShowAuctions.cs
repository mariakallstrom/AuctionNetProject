using AuctionNet.Controllers;
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
    public partial class FrmShowAuctions : Form
    {
        private readonly AuctionController _auctionController;
        public FrmShowAuctions()
        {
            InitializeComponent();
            _auctionController = new AuctionController();
            ShowAuctions();
        }

        public void ShowAuctions()
        {
            var auctions = _auctionController.GetAuctionsHighestBids();
            dgvAllAuction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAllAuction.BackgroundColor = Color.White;
            dgvAllAuction.RowHeadersVisible = false;
            dgvAllAuction.DataSource = auctions;
        }
    }
}
