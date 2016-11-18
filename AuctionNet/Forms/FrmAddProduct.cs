using AuctionNet.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        /* Låt stå
         byte[] test = _productContoller.GetAllProducts().Where(x => x.Id == 5).Select(x => x.Picture).Single();
         File.WriteAllBytes(@"C:\Users\Carl-Fredrik\Desktop\test.png", test);
         */

        byte[] imageBytes;
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
                    SupplierId = int.Parse(txtSupplier.Text),
                    Picture = imageBytes
                   
                });

                if (result.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, result), "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                MessageBox.Show("Ny produkten är inlagd");
                }
            
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    imageBytes = File.ReadAllBytes(file);
                }
                catch (IOException)
                {
                    MessageBox.Show("Bilden gick inte att läsa in.");
                }
            }
        }
    }
}
 