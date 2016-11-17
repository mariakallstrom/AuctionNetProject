
using System;

using System.Windows.Forms;
using AuctionNet.Controllers;

namespace AuctionNet.Forms
{
    public partial class FrmAddCustomer : Form
    {
        private readonly CustomerController _customerController;
        
        public FrmAddCustomer()
        {
            _customerController = new CustomerController();
            InitializeComponent();
            Formcust = this;
        }

        public static FrmAddCustomer Formcust;

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            _customerController.AddCustomer();
        }
    }
}
