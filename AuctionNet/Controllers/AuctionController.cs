using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using AuctionNet.Forms;
using AuctionNet.Interfaces;
using AuctionNet.Models;

namespace AuctionNet.Controllers
{
   public class AuctionController:IAuctionController
   {

       private readonly AuctionNetModel _auctionNetModel;

       public AuctionController()
       {
           _auctionNetModel = new AuctionNetModel();
       }
        public void SaveAuction()
        {
            Auctions auction = new Auctions
            {
                AcceptPrice = Convert.ToDecimal(FrmAddAuction.FormAddAuc.txtAcceptPrice.Text),
                StartTime = Convert.ToDateTime(FrmAddAuction.FormAddAuc.txtStartTime.Text),
                EndTime = Convert.ToDateTime(FrmAddAuction.FormAddAuc.txtEndtime.Text),
                ProductId = Convert.ToInt16(FrmAddAuction.FormAddAuc.txtProductId.Text)
            };
            _auctionNetModel.Auctions.Add(auction);
            _auctionNetModel.SaveChanges();
        }

        public List<Auctions> GetAllAuctions()
        {
            return _auctionNetModel.Auctions.ToList();
        }

        public List<MaxBid> GetAuctionsHighestBids()
        {
            return _auctionNetModel.MaxBid.ToList(); 
        }

        public List<Auctions> GetAuctionsesFromDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();

        }

        public List<object> GetAuctionsViewCommission(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}
