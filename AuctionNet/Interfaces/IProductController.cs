using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces
{
    interface IProductController
    {
        void ValidateInput();
        void SaveProduct();

        void UppDateProduct();

        void DeleteProduct();

        List<Products> GetAllProducts();




    }
}
