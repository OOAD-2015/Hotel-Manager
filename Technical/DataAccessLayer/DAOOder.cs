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
    public class DAOOrder
    {
         /// <summary>
        /// Phương thức lấy tất cả các Room từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllOrder()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllOrder");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Phương thức lấy Order theo id của Room
        /// </summary>
        /// <param name="strOrderID">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetOrderById(String strOrderID)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetOrderByID"/*Truyen vao storeprocedure*/, new object[1] { strOrderID });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Order theo id của Room
        /// </summary>
        /// <param name="strOrderLabel">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetOrderByLabel(String strOrderLabel)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetOrderByLabel"/*Truyen vao storeprocedure*/, new object[1] { strOrderLabel });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một Order vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertOrder(DTOOrder dtoOrder)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewOrderInsert"/*Truyen vao storeprocedure*/, new object[8] { dtoOrder.orderID, dtoOrder.customerID, dtoOrder.staffID, dtoOrder.orderOfDate, dtoOrder.numberOfPeople, dtoOrder.deposit, dtoOrder.total, dtoOrder.orderStatus });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một Order xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateOrder(DTOOrder dtoOrder)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditOrderUpdate"/*Truyen vao storeprocedure*/, new object[8] { dtoOrder.orderID, dtoOrder.customerID, dtoOrder.staffID, dtoOrder.orderOfDate, dtoOrder.numberOfPeople, dtoOrder.deposit, dtoOrder.total, dtoOrder.orderStatus });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
