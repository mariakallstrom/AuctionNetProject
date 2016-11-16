using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces
{
    interface ICustomerController
    {
        void ValidateInput();
        void AddCustomer();


        List<Customers> GetAllCustomers();

        List<object> GetAllBuyers();
    }
}
