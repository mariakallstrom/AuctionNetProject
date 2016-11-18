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
    public partial class FrmCustomerList : Form
    {
        private CustomerController _customerController;
        public FrmCustomerList()
        {
            _customerController = new CustomerController();
            InitializeComponent();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            var customers = _customerController.GetAllBuyers();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = customers;
        }
    }
}
