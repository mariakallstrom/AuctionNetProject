using AuctionNet.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AuctionNet.Interfaces;

namespace AuctionNet.Forms
{
    public partial class FrmShowAuctions : Form
    {
        private readonly AuctionController _auctionController;
        private readonly IBidController _bidController;
        private readonly IProductController _productController;
        private readonly ICustomerController _customerController;

        public FrmShowAuctions()
        {
            _bidController = new BidController();
            _productController = new ProductContoller();
            _customerController = new CustomerController();
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
            var auctions = _auctionController.GetAuctionsFromDate(CalendarView.SelectionStart.Date,
                CalendarView.SelectionEnd.Date);
            dgvAllAuction.DataSource =
                auctions.Select(
                    x =>
                        new
                        {
                            AuctionId = x.Id,
                            Name = x.Products.ProductName.ToString(),
                            AcceptPris = x.AcceptPrice,
                            Startdatum = x.StartTime,
                            SlutDatum = x.EndTime
                        }).ToList();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var auctions = _auctionController.GetAllAuctions();
            dgvAllAuction.DataSource =
                auctions.Select(
                    x =>
                        new
                        {
                            AuctionId = x.Id,
                            Name = x.Products.ProductName.ToString(),
                            AcceptPris = x.AcceptPrice,
                            Startdatum = x.StartTime,
                            SlutDatum = x.EndTime
                        }).ToList();
        }

        private void dgvAllAuction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                List<Bids> bids = new List<Bids>();
                Image test;
                int auctionId = int.Parse(dgvAllAuction.SelectedCells[0].AccessibilityObject.Value);
                try
                {
                    bids =
                        _bidController.GetAllBids()
                            .Where(x => x.AuctionId == auctionId).ToList();
                    var data =
                        _bidController.GetAllBids()
                            .Where(x => x.AuctionId == auctionId)
                            .Select(
                                x =>
                                    new
                                    {
                                        Name =
                                            _customerController.GetAllCustomers()
                                                .Where(k => k.Id == x.CustomerId)
                                                .Select(k => k.Name)
                                                .Single(),
                                        Bud = x.Bid,
                                        Datum = x.Date.ToShortDateString()
                                    })
                            .ToList();
                    bidHistory.DataSource = data;

                }
                catch (Exception)
                {
                    MessageBox.Show("Kunde inte hämta bud");
                }
                try
                {

                    var productId =
                        _auctionController.GetAllAuctions()
                            .Where(x => x.Id == auctionId)
                            .Select(x => x.ProductId)
                            .Single();

                    var pictureBytes =
                        _productController.GetAllProducts()
                            .Where(x => x.Id == productId)
                            .Select(x => x.Picture)
                            .Single();
                    Image newPic = (Bitmap) ((new ImageConverter()).ConvertFrom(pictureBytes));

                    pictureBox1.Image = newPic;
                }
                catch (Exception)
                {
                    MessageBox.Show("Kunde inte hämta bild");
                }
            }
        }
        
    }

