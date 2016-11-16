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

namespace AuctionNet.Forms
{
    public partial class FrmAddProduct : Form, IAuctionController
    {
        public FrmAddProduct()
        {
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
    }
}
