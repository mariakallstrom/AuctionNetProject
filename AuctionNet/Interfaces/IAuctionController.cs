using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuctionNet.Models;

namespace AuctionNet.Interfaces
{
    interface IAuctionController
    {
        
        void SaveAuction();

        List<Auctions> GetAllAuctions();

        List<MaxBid> GetAuctionsHighestBids();

        List<Auctions> GetAuctionsFromDate(DateTime start, DateTime end);

        List<AuctionHistory> GetAuctionsViewCommission();


    }
}
