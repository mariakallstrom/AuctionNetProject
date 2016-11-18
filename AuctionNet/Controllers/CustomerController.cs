using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuctionNet.Forms;
using AuctionNet.Interfaces;

namespace AuctionNet.Controllers
{
    public class CustomerController:ICustomerController
    {
        private readonly AuctionNetModel _auctionNetModel;

        public CustomerController()
        {
            _auctionNetModel = new AuctionNetModel();
        }
   

        public void AddCustomer()
        {
            Customers customer = new Customers
            {
                Name = FrmAddCustomer.Formcust.txtCustomerName.Text,
                Email = FrmAddCustomer.Formcust.txtCustomerEmail.Text,
                Phone = FrmAddCustomer.Formcust.txtCustomerTelephone.Text
            };
            _auctionNetModel.Customers.Add(customer);
            _auctionNetModel.SaveChanges();
        }

        public List<Customers> GetAllCustomers()
        {
            return _auctionNetModel.Customers.ToList();

        }

        public List<KeyValuePair<string, decimal>> GetAllBuyers()
        {
            var all = _auctionNetModel.AuctionHistory.ToList();

            var buyers =
                all.GroupBy(x => x.CustomerName)
                    .ToDictionary(k => k.Key,
                        k => all.Where(x => x.CustomerName == k.Key).Select(f => f.EndPrice).Aggregate((y, c) => y + c))
                    .ToList();


            return buyers;


        }
    }
}
