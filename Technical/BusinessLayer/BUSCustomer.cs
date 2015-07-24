using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using DataTransferObject;

namespace BusinessLayer
{
    public class BUSCustomer
    {
        public DAOCustomer daoCustomer;
        public BUSCustomer()
        {
            this.daoCustomer = new DAOCustomer();
        }

        public DataTable getAllData()
        {
            return daoCustomer.getAllData();
        }
        public DataTable getCustomerName()
        {
            return daoCustomer.getCustomerName();
        }

        public DataTable getCustomerIDByName(string customerName)
        {
            return daoCustomer.getCustomerIDByName(customerName);
        }

        public int updateData(DTOCustomer _dtoCustomer)
        {
            if (_dtoCustomer != null)
            {
                return daoCustomer.updateData(_dtoCustomer);
            }
            return -1;
        }

        public int deleteData(string customerID)
        {
            if (customerID != null)
            {
                return daoCustomer.deleteData(customerID);
            }
            return -1;
        }

        public int insertData(DTOCustomer _dtoCustomer)
        {
            if (_dtoCustomer != null)
            {
                return daoCustomer.insertData(_dtoCustomer);
            }
            return -1;
        }
    }
}
