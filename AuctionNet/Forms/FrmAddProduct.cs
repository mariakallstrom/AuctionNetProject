using AuctionNet.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionNet.Controllers;
using AuctionNet.Models;

namespace AuctionNet.Forms
{
    public partial class FrmAddProduct : Form
    {
      
        private readonly ProductContoller _productContoller;
        public FrmAddProduct()
        {
           
            _productContoller = new ProductContoller();
            InitializeComponent();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
          

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
             var result = _productContoller.Create(new Products
                {
                    ProductName = txtProductName.Text,
                    Description = txtDescription.Text,
                    StartPrice = decimal.Parse(txtStartPrice.Text.Replace(".", ",")),
                    Commission = decimal.Parse(txtCommission.Text.Replace(".", ",")),
                    SupplierId = int.Parse(txtSupplier.Text)
                });

                if (result.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, result), "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                MessageBox.Show("New product is added!");
                }
            
        }
    }
}