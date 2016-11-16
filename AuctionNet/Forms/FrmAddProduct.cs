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
using AuctionNet.Controllers;

namespace AuctionNet.Forms
{
    public partial class FrmAddProduct : Form
    {
        private readonly AuctionNetModel _auctionNetModel;
        private readonly ProductContoller _productContoller;
        public FrmAddProduct()
        {
            _auctionNetModel = new AuctionNetModel();
            _productContoller = new ProductContoller();
            InitializeComponent();
        }

        public List<Auctions> GetAllAuctions()
        {
            throw new NotImplementedException();
        }

        public List<Auctions> GetAuctionsesFromDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public List<Auctions> GetAuctionsHighestBids()
        {
            throw new NotImplementedException();
        }

        public List<object> GetAuctionsViewCommission(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public void SaveAuction()
        {
            throw new NotImplementedException();
        }

        public void SaveProduct()
        {
            throw new NotImplementedException();
        }

        public void ValidateInput()
        {
            throw new NotImplementedException();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
          

        }

        // todo lösa error på convert delen nedan

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            {
             var result = _productContoller.Create(new Products
                {
                    ProductName = txtProductName.Text,
                    Description = txtDescription.Text,
                    StartPrice = Convert.ToDecimal(txtStartPrice.Text),
                    Commission = Convert.ToDecimal(txtCommission.Text),
                    SupplierId = Convert.ToInt32(txtSupplier.Text),
                });

                MessageBox.Show("New product is added!");

                if (result.Count <0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, result), "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            
    }
}
}