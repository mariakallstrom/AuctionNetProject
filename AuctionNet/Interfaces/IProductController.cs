using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces 
{
    interface IProductController
    {

        List<ValidationResult> Create(Products product);

        List<Products> GetAllProducts();




    }
}
