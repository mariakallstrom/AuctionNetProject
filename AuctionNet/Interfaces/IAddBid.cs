using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces
{
    interface IAddBid
    {
        DateTime Date { get; set; }
        int Bid { get; set; }
        int CustomerId { get; set; }
        int AuctionId { get; set; }

        void ValidateInput();
        void SaveProduct();
    }
}
