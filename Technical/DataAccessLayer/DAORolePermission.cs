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
    public class DAORolePermission
    {
        public DAORolePermission()
        {

        }

        /// <summary>
        /// Phương thức lấy tất cả các RolePermission từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRolePermission()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllRolePermission");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy RolePermission theo id của RolePermission
        /// </summary>
        /// <param name="iRolePermissionId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetRolePermissionById(String strRolePermissionId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRolePermissionByID"/*Truyen vao storeprocedure*/, new object[1] { strRolePermissionId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Ten RolePermission theo id của RolePermission
        /// </summary>
        /// <param name="iRolePermissionId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetRolePermissionNameById(String strRolePermissionId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRolePermissionNameByID"/*Truyen vao storeprocedure*/, new object[1] { strRolePermissionId });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một RolePermission vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertRolePermission(DTORolePermission rolePermission)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewRolePermissionInsert"/*Truyen vao storeprocedure*/, new object[2] { rolePermission.RolePermissionID, rolePermission.RolePermissionName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức cập nhật một RolePermission xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateRolePermission(DTORolePermission rolePermission)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditRolePermissionUpdate"/*Truyen vao storeprocedure*/, new object[2] { rolePermission.RolePermissionID, rolePermission.RolePermissionName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức xóa một RolePermission theo id
        /// </summary>
        /// <param name="iRolePermissionId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteRolePermission(String strRolePermissionId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteRolePermission"/*Truyen vao storeprocedure*/, new object[1] { strRolePermissionId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }

        public DataTable LookAtRolePermission(String strRolePermissionName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtRolePermissionDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strRolePermissionName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
