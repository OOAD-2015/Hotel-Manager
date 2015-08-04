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
    public class DAOServicesType
    {
        /// <summary>
        /// Phương thức lấy tất cả các ServicesType từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllServicesType()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllServicesType");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy ServicesType theo id của ServicesType
        /// </summary>
        /// <param name="iServicesTypeId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetServicesTypeById(String strServicesTypeId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetServicesTypeByID"/*Truyen vao storeprocedure*/, new object[1] { strServicesTypeId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một ServicesType vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertServicesType(DTOServicesType ServicesType)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewServicesTypeInsert"/*Truyen vao storeprocedure*/, new object[2] { ServicesType.ServicesTypeID, ServicesType.ServicesTypeName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức cập nhật một ServicesType xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateServicesType(DTOServicesType ServicesType)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditServicesTypeUpdate"/*Truyen vao storeprocedure*/, new object[2] { ServicesType.ServicesTypeID, ServicesType.ServicesTypeName});
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức xóa một ServicesType theo id
        /// </summary>
        /// <param name="iServicesTypeId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteServicesType(String strServicesTypeId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteServicesType"/*Truyen vao storeprocedure*/, new object[1] { strServicesTypeId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }

        public DataTable LookAtServicesType(String strServicesTypeName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtServicesTypeDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strServicesTypeName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
