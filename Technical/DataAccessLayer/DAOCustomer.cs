using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAOCustomer
    {
        public void CreateCustomer(CUSTOMER customer)
        {
            DataContextInitializer.DbContext.CUSTOMERs.InsertOnSubmit(customer);
            DataContextInitializer.DbContext.SubmitChanges();
        }

        public void UpdateCustomer(CUSTOMER customer)
        {
            IQueryable<CUSTOMER> _customerList = DataContextInitializer.DbContext.CUSTOMERs.Where(cus=>cus.CustomerID == customer.CustomerID);
            foreach (CUSTOMER _customer in _customerList)
            {
                _customer.CustomerID = customer.CustomerID;
                _customer.Address = customer.Address;
                _customer.CustomerName = customer.CustomerName;
                _customer.DateOfBirth = customer.DateOfBirth;
                _customer.Gender = customer.Gender;
                _customer.IDNumber = customer.IDNumber;
                _customer.PhoneNumber = customer.PhoneNumber;
            }
            DataContextInitializer.DbContext.SubmitChanges();
        }

        public void DeleteCustomer(CUSTOMER customer)
        {
            DataContextInitializer.DbContext.CUSTOMERs.DeleteOnSubmit(customer);
            DataContextInitializer.DbContext.SubmitChanges();
        }

        public void DeleteCustomer(string customerID)
        {
            IQueryable<CUSTOMER> _customerList = DataContextInitializer.DbContext.CUSTOMERs.Where(cus => cus.CustomerID == customerID);
            foreach (CUSTOMER _customer in _customerList)
            {
                DataContextInitializer.DbContext.CUSTOMERs.DeleteOnSubmit(_customer);
            }
            DataContextInitializer.DbContext.SubmitChanges();
        }
    }
}
