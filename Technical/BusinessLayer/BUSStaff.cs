using DataAccessLayer;
using DataTransferObject;
using DataTransferObject.Utils;
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
    public class BUSStaff
    {
        private DAOStaff staffDAO;
        private DAORule ruleDAO;
        public BUSStaff()
        {
            staffDAO = new DAOStaff();
            ruleDAO = new DAORule();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Staff từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllStaff()
        {
            try
            {
                return staffDAO.GetAllStaff();
            }
            catch (SqlException)
            {

                throw;
            }
        }

        /// <summary>
        /// Phương thức lấy Staff theo id của Staff
        /// </summary>
        /// <param name="iStaffId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetStaffById(String strStaffId)
        {
            try
            {
                return staffDAO.GetStaffById(strStaffId);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy doi tuong Staff theo User name của Staff
        /// </summary>
        /// <param name="iStaffId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DTOStaff GetStaffByIdToObject(String strStaffId)
        {
            try
            {
                strStaffId = Utils.StandStringSpace(strStaffId);

                DataTable tb = GetStaffById(strStaffId);

                if (tb.Rows.Count > 0)
                {
                    DTOStaff objStaff = new DTOStaff();
                    objStaff.StaffID = tb.Rows[0][0].ToString();
                    objStaff.Name = tb.Rows[0][1].ToString();
                    objStaff.Gender = tb.Rows[0][2].ToString();
                    objStaff.Birthday = Convert.ToDateTime(tb.Rows[0][3].ToString());
                    objStaff.Address = tb.Rows[0][4].ToString();
                    objStaff.Phone = tb.Rows[0][5].ToString();
                    objStaff.Email = tb.Rows[0][6].ToString();
                    objStaff.DateCreated = Convert.ToDateTime(tb.Rows[0][7].ToString());
                    objStaff.RolePermissionId = tb.Rows[0][8].ToString();
                    objStaff.UserName = tb.Rows[0][9].ToString();
                    objStaff.Password = tb.Rows[0][10].ToString();

                    return objStaff;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        /// <summary>
        /// Phương thức lấy Staff theo id của Staff
        /// </summary>
        /// <param name="iStaffId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetStaffByUserName(String strStaffUsername)
        {
            try
            {
                return staffDAO.GetStaffByUserName(strStaffUsername);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy doi tuong Staff theo User name của Staff
        /// </summary>
        /// <param name="iStaffId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DTOStaff GetStaffByUserNameToObject(String strStaffUsername)
        {
            try
            {
                strStaffUsername = Utils.StandStringSpace(strStaffUsername);

                DataTable tb = GetStaffByUserName(strStaffUsername);

                if (tb.Rows.Count > 0)
                {
                    DTOStaff objStaff = new DTOStaff();
                    objStaff.StaffID = tb.Rows[0][1].ToString();
                    objStaff.Name = tb.Rows[0][2].ToString();
                    objStaff.Gender = tb.Rows[0][3].ToString();
                    objStaff.Birthday = Convert.ToDateTime(tb.Rows[0][4].ToString());
                    objStaff.Address = tb.Rows[0][5].ToString();
                    objStaff.Phone = tb.Rows[0][6].ToString();
                    objStaff.Email = tb.Rows[0][7].ToString();
                    objStaff.DateCreated = Convert.ToDateTime(tb.Rows[0][8].ToString());
                    objStaff.RolePermissionId = tb.Rows[0][9].ToString();
                    objStaff.UserName = tb.Rows[0][10].ToString();
                    objStaff.Password = tb.Rows[0][11].ToString();

                    return objStaff;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public DTORolePermission GetRolePermissionByPositionId(String strPositionId)
        {
            try
            {
                DTORolePermission rolePermissionObj;
                BUSRolePermission rolePermissionBUS = new BUSRolePermission();
                DataTable tb = rolePermissionBUS.GetRolePermissionById(strPositionId);
                if (tb.Rows.Count > 0)
                {
                    rolePermissionObj = new DTORolePermission();
                    if (!tb.Rows[0][3].ToString().Equals(""))
                    {
                        rolePermissionObj.SystemManager = Boolean.Parse(tb.Rows[0][3].ToString());
                        rolePermissionObj.ChangeRule = Boolean.Parse(tb.Rows[0][4].ToString());
                    }
                }
                else
                    return null;
                return rolePermissionObj;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức thêm mới một Staff vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertStaff(DTOStaff Staff)
        {
            try
            {
                return staffDAO.InsertStaff(Staff);
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
        public bool UpdateStaff(DTOStaff Staff)
        {
            try
            {
                return staffDAO.UpdateStaff(Staff);
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
        public bool UpdateStaffNoUsernamePassword(DTOStaff Staff)
        {
            try
            {
                return staffDAO.UpdateStaffNoUsernamePassword(Staff);
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
                return staffDAO.UpdateStaffForPassword(strStaffId, strPassword);
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
                return staffDAO.DeleteStaff(strStaffId);
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
                return staffDAO.LookAtStaffByIdDataFromDatabase(strStaffId);
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
                return staffDAO.LookAtStaffByNameDataFromDatabase(strStaffName);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public bool CheckLoginToSystem(String strUsername, String strPassword)
        {
            strUsername = Utils.StandStringSpace(strUsername);
            strPassword = Utils.StandStringSpace(strPassword);
            strPassword = Utils.GetMD5(strPassword);
            DTOStaff staff = GetStaffByUserNameToObject(strUsername);
            if (staff != null)
            {
                if (staff.Password.Equals(strPassword) && staff.UserName.Equals(strUsername))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool checkAge(DateTime dBirthday, DateTime dDateInput)
        {
            int minAge = Int32.Parse(ruleDAO.GetRuleByLabel("DoTuoiNhanVienToiThieu"));
            int maxAge = Int32.Parse(ruleDAO.GetRuleByLabel("DoTuoiNhanVienToiDa"));
            if ((dDateInput.Year - dBirthday.Year) >= minAge && (dDateInput.Year - dBirthday.Year) <= maxAge)
                return true;
            else
            {
                return false;
            }
        }
    }
}
