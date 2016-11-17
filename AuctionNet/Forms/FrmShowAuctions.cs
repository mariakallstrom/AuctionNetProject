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

        private void btnGet_Click(object sender, EventArgs e)
        {
            dgvAllAuction.DataSource = _auctionController.GetAuctionsFromDate(CalendarView.SelectionStart.Date, CalendarView.SelectionEnd.Date);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            var auctions = _auctionController.GetAllAuctions().ToList();
            dgvAllAuction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAllAuction.BackgroundColor = Color.White;
            dgvAllAuction.RowHeadersVisible = false;
            dgvAllAuction.DataSource = auctions;
        }
    }
}
