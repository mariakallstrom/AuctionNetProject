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
    public partial class FrmShowCommissionPerMonth : Form
    {
        private readonly AuctionController _auctionController;
        public FrmShowCommissionPerMonth()
        {
            _auctionController = new AuctionController();
            InitializeComponent();
          
        }

        private void FrmShowCommissionPerMonth_Load(object sender, EventArgs e)
        {

            var a = _auctionController.GetAuctionsViewCommission().
                GroupBy(x => new {x.EndDate.Year, x.EndDate.Month}).
                Select(z => new
                {
                    Year = z.FirstOrDefault().EndDate.Year,
                    Month = z.FirstOrDefault().EndDate.Month,
                    Commission = z.Sum(r => r.EndPrice) * z.FirstOrDefault().Commission
                }).ToList();


            dataGridView1.DataSource = a;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
