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
    public class DAOServiceDetail
    {
        /// <summary>
        /// Phương thức lấy tất cả các ServiceDetail từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllServiceDetail()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllServiceDetail");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy ServiceDetail theo id của ServiceDetail
        /// </summary>
        /// <param name="iServiceDetailId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetServiceDetailById(String strServiceDetailId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetServiceDetailByID"/*Truyen vao storeprocedure*/, new object[1] { strServiceDetailId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy ServiceDetail theo id của ServiceDetail
        /// </summary>
        /// <param name="iServiceDetailId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServiceDetailByLabel(String strServiceDetailLabel)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetServiceDetailByLabel"/*Truyen vao storeprocedure*/, new object[1] { strServiceDetailLabel });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một ServiceDetail vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertServiceDetail(DTOServiceDetail ServiceDetail)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewServiceDetailInsert"/*Truyen vao storeprocedure*/, new object[5] { ServiceDetail.ServicesDetailID, ServiceDetail.OrderDetailID, ServiceDetail.ServicesID, ServiceDetail.Quantity, ServiceDetail.Total });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một ServiceDetail xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateServiceDetail(DTOServiceDetail ServiceDetail)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditServiceDetailUpdate"/*Truyen vao storeprocedure*/, new object[5] { ServiceDetail.ServicesDetailID, ServiceDetail.OrderDetailID, ServiceDetail.ServicesID, ServiceDetail.Quantity, ServiceDetail.Total });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một ServiceDetail theo id
        /// </summary>
        /// <param name="iServiceDetailId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteServiceDetail(String strServiceDetailId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteServiceDetail"/*Truyen vao storeprocedure*/, new object[1] { strServiceDetailId });
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
        public DataTable GetAllServiceDetailByOrderID(String strOrderID)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllServiceDetailByOrderID", new object[1] { strOrderID });
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
        /// <param name="strOrderID"></param>
        /// <returns></returns>
        public bool DeleteAllServiceDetailByOrderID(String strOrderID)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteAllServiceDetailByOrderID", new object[1] { strOrderID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
