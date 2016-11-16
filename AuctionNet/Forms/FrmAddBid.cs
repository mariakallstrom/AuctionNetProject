using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionNet.Interfaces;

namespace AuctionNet.Forms
{
    public partial class FrmAddBid : Form
    {
        public FrmAddBid()
        {
            InitializeComponent();
        }

        public int AuctionId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Bid
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int CustomerId
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        //datetime.now
        public DateTime Date
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Bids> GetAllBids()
        {
            throw new NotImplementedException();
        }

        public List<object> GetHighestBidPerAuction()
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
