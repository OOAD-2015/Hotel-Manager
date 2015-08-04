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
    public class DAOStatus
    {
        /// <summary>
        /// Phương thức lấy tất cả các Status từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllStatus()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllStatus");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Status theo id của Status
        /// </summary>
        /// <param name="iStatusId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetStatusById(String strStatusId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetStatusByID"/*Truyen vao storeprocedure*/, new object[1] { strStatusId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một Status vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertStatus(DTOStatus Status)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewStatusInsert"/*Truyen vao storeprocedure*/, new object[2] { Status.StatusID, Status.StatusName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức cập nhật một Status xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateStatus(DTOStatus Status)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditStatusUpdate"/*Truyen vao storeprocedure*/, new object[2] { Status.StatusID, Status.StatusName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức xóa một Status theo id
        /// </summary>
        /// <param name="iStatusId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteStatus(String strStatusId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteStatus"/*Truyen vao storeprocedure*/, new object[1] { strStatusId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }

        public DataTable LookAtStatus(String strStatusName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtStatusDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strStatusName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
