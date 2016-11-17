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
            var auctions = _auctionController.GetAllAuctions();
            dgvAllAuction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAllAuction.BackgroundColor = Color.White;
            dgvAllAuction.RowHeadersVisible = false;
            dgvAllAuction.DataSource = auctions;
        }

        private void FrmShowAuctions_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAuctionNetStartPage f = new FrmAuctionNetStartPage();
            f.Show();
            Hide();
        }
    }
}
