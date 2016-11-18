using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces
{
    interface IBidController
    {
        List<Bids> GetAllBids();

        List<object> GetHighestBidPerAuction();

        List<ValidationResult> Create(Bids bid);
    }
}
