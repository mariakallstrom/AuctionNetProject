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
    public partial class FrmAddProduct : Form, IAddProduct
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        public void SaveProduct()
        {
            throw new NotImplementedException();
        }

        public void ValidateInput()
        {
            throw new NotImplementedException();
        }
    }
}
