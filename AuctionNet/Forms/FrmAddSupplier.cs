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

namespace AuctionNet.Forms
{
    public partial class FrmAddSupplier : Form
    {
        private readonly AuctionNetModel _auctionNetModel;
        private readonly SupplierController _supplierController;
        public FrmAddSupplier()
        {
            _auctionNetModel = new AuctionNetModel();
            _supplierController = new SupplierController();
            InitializeComponent();
        }

        private void FrmAddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            {
                var result = _supplierController.Create(new Suppliers
                {

                    Name = Convert.ToString(txtSupplierName),
                    Phone = Convert.ToString(txtSupplierTelephone)
                });
                MessageBox.Show("A new supplier has been saved!");

                if (result.Count < 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, result), "An error was found", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}

