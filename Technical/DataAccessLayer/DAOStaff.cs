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
    public class DAOStaff
    {
        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public DAOStaff()
        {
        }

        /// <summary>
        /// Phương thức lấy tất cả các Staff từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllStaff()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllStaff");

                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy Staff theo Staff Id của Staff
        /// </summary>
        /// <param name="iStaffId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetStaffById(String strStaffId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetStaffById"/*Truyen vao storeprocedure*/, new object[1] { strStaffId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }


        /// <summary>
        /// Phương thức lấy Staff theo tên đăng nhập của Staff
        /// </summary>
        /// <param name="iStaffId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetStaffByUserName(String strStaffUsername)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetStaffByUserName"/*Truyen vao storeprocedure*/, new object[1] { strStaffUsername });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        public bool InsertStaff(DTOStaff staff)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewStaffInsert", new object[11] { staff.StaffID, staff.Name, staff.Gender, staff.Birthday, staff.Address, staff.Phone, staff.Email, staff.DateCreated, staff.RolePermissionId, staff.UserName, staff.Password });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một Staff xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateStaff(DTOStaff staff)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditStaffUpdate", new object[10] { staff.StaffID, staff.Name, staff.Gender, staff.Birthday, staff.Address, staff.Phone, staff.Email, staff.DateCreated, staff.RolePermissionId, staff.Password });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        /// <summary>
        /// Phương thức cập nhật một Staff xuống csdl theo id ko thay doi user name password
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateStaffNoUsernamePassword(DTOStaff staff)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditStaffUpdateNoUsernamePassword", new object[9] { staff.StaffID, staff.Name, staff.Gender, staff.Birthday, staff.Address, staff.Phone, staff.Email, staff.DateCreated, staff.RolePermissionId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        /// <summary>
        /// Phương thức cập nhật mật khẩu đăng nhập của  Staff xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateStaffForPassword(String strStaffId, String strPassword)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditStaffUpdateForPassword", new object[2] { strStaffId, strPassword });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một Staff theo id
        /// </summary>
        /// <param name="iStaffId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteStaff(String strStaffId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteStaff", new object[1] { strStaffId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtStaffByIdDataFromDatabase(String strStaffId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtStaffByIdDataFromDatabase", new object[1] { strStaffId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        public DataTable LookAtStaffByNameDataFromDatabase(String strStaffName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtStaffByNameDataFromDatabase", new object[1] { strStaffName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
