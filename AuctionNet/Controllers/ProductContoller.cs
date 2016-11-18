﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using AuctionNet.Interfaces;

namespace AuctionNet.Controllers
{
    public class ProductContoller : IProductController
    {
        private AuctionNetModel _auctionNetModel;

        public ProductContoller()
        {
            _auctionNetModel = new AuctionNetModel();
        }

        public List<ValidationResult> Create(Products products)
        {
            ValidationContext context = new ValidationContext(products, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(products, context, result, true);
            if (valid)
            {
                _auctionNetModel.Products.Add(products);
                _auctionNetModel.SaveChanges();
               
            }
            return result;
        }

        public List<Products> GetAllProducts()
        {
            return _auctionNetModel.Products.ToList();
        }


    }
}
