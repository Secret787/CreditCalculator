using CreditCalculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator.DataAccess
{
    public class CustomerAddedEventArgs : EventArgs
    {
        public CustomerAddedEventArgs(Customer newCustomer)
        {
            this.NewCustomer = newCustomer;
        }

        public Customer NewCustomer { get; private set; }
    }
}
