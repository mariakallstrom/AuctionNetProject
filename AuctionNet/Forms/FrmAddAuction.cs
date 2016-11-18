﻿using AuctionNet.Interfaces;
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
    public partial class FrmAddAuction : Form
    {
        private readonly IAuctionController _auctionController;
        public FrmAddAuction()
        {
            _auctionController=new AuctionController();
            InitializeComponent();
            FormAddAuc = this;

        }

        public static FrmAddAuction FormAddAuc;
        private void FrmAddAuction_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAuction_Click(object sender, EventArgs e)
        {
            _auctionController.SaveAuction();
            //Clear();
            //FrmAuctionNetStartPage f = new FrmAuctionNetStartPage();
            //f.Show();
            //Hide();
        }

        public void Clear()
        {
            foreach (TextBox item in FormAddAuc.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
