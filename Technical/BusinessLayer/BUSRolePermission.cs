using DataAccessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * trungpv
 **/
namespace BusinessLayer
{
    public class BUSRolePermission
    {
         private DAORolePermission RolePermissionDAO;

        public BUSRolePermission()
        {
            RolePermissionDAO = new DAORolePermission();
        }

        /// <summary>
        /// Phương thức lấy tất cả các RolePermission từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRolePermission()
        {
            try
            {
                return RolePermissionDAO.GetAllRolePermission();
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
                return RolePermissionDAO.GetRolePermissionById(strRolePermissionId);
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
                return RolePermissionDAO.GetRolePermissionNameById(strRolePermissionId);
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
        public bool InsertRolePermission(DTORolePermission RolePermission)
        {
            try
            {
                return RolePermissionDAO.InsertRolePermission(RolePermission);
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
        public bool UpdateRolePermission(DTORolePermission RolePermission)
        {
            try
            {
                return RolePermissionDAO.UpdateRolePermission(RolePermission);
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
                return RolePermissionDAO.DeleteRolePermission(strRolePermissionId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtRolePermission(String strRolePermissionId)
        {
            try
            {
                return RolePermissionDAO.LookAtRolePermission(strRolePermissionId);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
