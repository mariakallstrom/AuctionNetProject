﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionNet.Interfaces
{
    interface IAddProduct
    {
        void ValidateInput();
        void SaveProduct();
    }
}
