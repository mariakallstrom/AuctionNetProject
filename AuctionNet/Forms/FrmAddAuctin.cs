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

namespace AuctionNet.Forms
{
    public partial class FrmAddAuctin : Form, IProductController
    {
        public FrmAddAuctin()
        {
            InitializeComponent();
        }

        public void DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void SaveProduct()
        {
            throw new NotImplementedException();
        }

        public void UppDateProduct()
        {
            throw new NotImplementedException();
        }

        public void ValidateInput()
        {
            throw new NotImplementedException();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {

                string selectedFile = open.FileName;
            }
        }
    }
}
