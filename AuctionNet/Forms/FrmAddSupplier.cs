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

        private readonly SupplierController _supplierController;

        public FrmAddSupplier()
        {

            _supplierController = new SupplierController();
            InitializeComponent();
        }

        private void btnAddSupplier_Click_1(object sender, EventArgs e)
        {

            var result = _supplierController.Create(new Suppliers
            {
                Name = txtSupplierName.Text,
                Phone = txtSupplierTelephone.Text
            });

            if (result.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result), "An error was found", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A new supplier has been saved!");
                Clear();
                FrmAuctionNetStartPage f = new FrmAuctionNetStartPage();
                f.Show();
            }


        }
        public void Clear()
        {
            txtSupplierTelephone.Text = "";
            txtSupplierName.Text = "";
        }

    }
}
