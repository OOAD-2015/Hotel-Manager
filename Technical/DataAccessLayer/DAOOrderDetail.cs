using DataTransferObject;
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


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public String GetOrderIDByOrderDetailID(String strOrderDetailId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetOrderIDByOrderDetailID", new object[1] { strOrderDetailId });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllOrderDetailsByOderID(string orderID)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllOrderByOderID", new object[1] { orderID });
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
        /// <param name="dtoOrderDetails"></param>
        /// <returns></returns>
        public bool InsertOrderDetails(DTOOrderDetail dtoOrderDetails)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewOrderDetail"/*Truyen vao storeprocedure*/, new object[7] { dtoOrderDetails.orderDetailID, dtoOrderDetails.orderID, dtoOrderDetails.roomID, dtoOrderDetails.startDate, dtoOrderDetails.endDate, dtoOrderDetails.estimate, dtoOrderDetails.servicesMoney });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public bool UpdateOrderDetails(DTOOrderDetail dtoOrderDetails)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditOrderDetail"/*Truyen vao storeprocedure*/, new object[7] { dtoOrderDetails.orderID, dtoOrderDetails.orderID, dtoOrderDetails.roomID, dtoOrderDetails.startDate, dtoOrderDetails.endDate, dtoOrderDetails.estimate, dtoOrderDetails.servicesMoney });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public bool DeleteOrderDetails(string orderID)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteOrderDetails"/*Truyen vao storeprocedure*/, new object[1] { orderID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable GetRevenueReportByMY(string M, string Y)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRevenueReportByMY", new object[2] { M, Y });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable GetRevenueReportByY(string Y)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRevenueReportByY", new object[1] {Y });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DataTable GetRevenueReportByFromTo(DateTime F, DateTime T)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRevenueReportByFromTo", new object[2] { F, T });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
