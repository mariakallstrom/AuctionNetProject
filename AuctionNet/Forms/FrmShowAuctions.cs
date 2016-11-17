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
            dgvBidHistory.BackgroundColor = Color.White;
            dgvAllAuction.RowHeadersVisible = false;
            dgvAllAuction.DataSource = auctions;

        }

        private void dgvAllAuction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var cellindex = dgvBidHistory.SelectedCells[0].RowIndex;
            //var cellcollection = dgvBidHistory.Rows[cellindex].Cells[0];
            //int auctionId = (int)dgvBidHistory.Value;

            DataGridViewRow row = this.dgvAllAuction.SelectedRows[0];
            int auctionId = (int)row.Cells["Id"].Value;

            //int auctionId = (int)dgvBidHistory.SelectedRows[0].Cells[0].Value;
            var bidHistory = _auctionController.GetBidHistory(auctionId);
            dgvBidHistory.DataSource = bidHistory;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
