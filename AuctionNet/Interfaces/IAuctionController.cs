using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces
{
    interface IAuctionController
    {
        
        void SaveAuction();

        List<Auctions> GetAllAuctions();

        List<object> GetAuctionsHighestBids();

        List<Auctions> GetAuctionsesFromDate(DateTime start, DateTime end);

        List<object> GetAuctionsViewCommission(DateTime start, DateTime end);


    }
}
