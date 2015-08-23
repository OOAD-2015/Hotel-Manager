using DataTransferObject.Extention;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAOOrderDetail
    {
        /// <summary>
        /// lấy tất cả order detail từ hôm nay
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllOrderDetailFromNow()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllOrderDetailFromNow");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strServicesId"></param>
        /// <returns></returns>
        public bool UpdateServiceMoneyOrderDetailById(String strOrderDetailId, int ServiceMoney)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_UpdateServiceMoneyOrderDetailById"/*Truyen vao storeprocedure*/, new object[2] { strOrderDetailId, ServiceMoney });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {
                throw;
            }

        }
    }
}
