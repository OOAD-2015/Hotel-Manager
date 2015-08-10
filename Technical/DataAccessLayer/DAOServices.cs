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
    public class DAOServices
    {
        /// <summary>
        /// Phương thức lấy tất cả các Services từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllServices()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllServices");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy Services theo id của Services
        /// </summary>
        /// <param name="iServicesId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServicesById(String strServicesId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetServicesByID"/*Truyen vao storeprocedure*/, new object[1] { strServicesId });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Services theo id của Services
        /// </summary>
        /// <param name="iServicesId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServicesByLabel(String strServicesLabel)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetServicesByLabel"/*Truyen vao storeprocedure*/, new object[1] { strServicesLabel });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một Services vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertServices(DTOServices Services)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewServicesInsert"/*Truyen vao storeprocedure*/, new object[5] { Services.ServicesID, Services.ServicesName, Services.ServicesTypeID, Services.Price, Services.UnitID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một Services xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateServices(DTOServices Services)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditServicesUpdate"/*Truyen vao storeprocedure*/, new object[5] { Services.ServicesID, Services.ServicesName, Services.ServicesTypeID, Services.Price, Services.UnitID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một Services theo id
        /// </summary>
        /// <param name="iServicesId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteServices(String strServicesId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteServices"/*Truyen vao storeprocedure*/, new object[1] { strServicesId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtServices(String strServicesName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtServicesDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strServicesName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
