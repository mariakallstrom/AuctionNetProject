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
    public partial class FrmCustomerList : Form
    {
        private readonly CustomerController _customerController;
        public FrmCustomerList()
        {
            InitializeComponent();
            _customerController = new CustomerController();
            showCustomers();
        }

        public void showCustomers()
        {
            var customers = _customerController.GetAllBuyers();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = customers;
            //dataGridView1.Columns["StartPrice" ].Visible = false;
            //dataGridView1.Columns["SuplierName"].Visible = false;
            //dataGridView1.Columns["ProductName"].Visible = false;
            //dataGridView1.Columns["AuctionNumber"].Visible = false;


        }
    }
}
