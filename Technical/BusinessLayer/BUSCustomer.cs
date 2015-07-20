using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUSCustomer
    {
        public DAOCustomer daoCustomer;
        public BUSCustomer()
        {
            this.daoCustomer = new DAOCustomer();
        }

        public void CreateCustomer(CUSTOMER customer)
        {
            this.daoCustomer.CreateCustomer(customer);
        }

        public void UpdateCustomer(CUSTOMER customer)
        {
            this.daoCustomer.UpdateCustomer(customer);
        }

        public void DeleteCustomer(CUSTOMER customer)
        {
            this.daoCustomer.DeleteCustomer(customer);
        }

        public void DeleteCustomer(string customerID)
        {
            this.daoCustomer.DeleteCustomer(customerID);
        }
    }
}
