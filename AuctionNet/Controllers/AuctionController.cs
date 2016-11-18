using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            MessageBox.Show(@"En Auktion har lagts till");
        }

        public string OrderSales()
        { 
             var monthlyCommission = _auctionNetModel.AuctionHistory.ToList();
        var testa = monthlyCommission.GroupBy(x => x.CustomerName)
            .ToDictionary(k => k.Key,
                k => monthlyCommission.Where(x => x.CustomerName == k.Key).Select(f => f.EndPrice).Aggregate((y, c) => y + c)).ToList();

            return testa;
        }
        //{
        //    var list = new List<string>();
        //    var query = from auctionHistory in _auctionNetModel.AuctionHistory
        //                group auctionHistory by auctionHistory.EndDate.Month
        //                into groupDate

        //                select new
        //                {
        //                    Month = groupDate.Key,
        //                    Saletotal = groupDate.Sum(AuctionHistory)

        //                };
        //    foreach (var q in query)
        //    {
        //        var report = $"Month: {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(q.Month)} - Total Sales: {q.Saletotal}";
        //        list.Add(report);
        //    }

        //    return String.Join("\n", list);
        //}


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
