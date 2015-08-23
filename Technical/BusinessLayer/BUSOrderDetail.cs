using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BUSOrderDetail
    {
        private DAOOrderDetail orderDetailDAO = new DAOOrderDetail();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllOrderDetailFromNow()
        {
            return orderDetailDAO.GetAllOrderDetailFromNow();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strServicesId"></param>
        /// <returns></returns>
        public bool UpdateServiceMoneyOrderDetailById(String strOrderDetailId, int ServiceMoney)
        {
            return orderDetailDAO.UpdateServiceMoneyOrderDetailById(strOrderDetailId, ServiceMoney);
        }
    }
}
