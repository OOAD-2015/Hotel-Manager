using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BUSRule
    {
         private DAORule regulationDAO;

        public BUSRule()
        {
            regulationDAO = new DAORule();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Rule từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRule()
        {
            try
            {
                return regulationDAO.GetAllRule();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy Rule theo id của Rule
        /// </summary>
        /// <param name="iRuleId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetRuleById(String strRuleId)
        {
            try
            {
                return regulationDAO.GetRuleById(strRuleId);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Rule theo id của Rule
        /// </summary>
        /// <param name="iRuleId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetRuleByLabel(String strRuleLabel)
        {
            try
            {
                return regulationDAO.GetRuleByLabel(strRuleLabel);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức thêm mới một Rule vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertRule(DTORule Rule)
        {
            try
            {
                return regulationDAO.InsertRule(Rule);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một Rule xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateRule(DTORule Rule)
        {
            try
            {
                return regulationDAO.UpdateRule(Rule);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một Rule theo id
        /// </summary>
        /// <param name="iRuleId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteRule(String strRuleId)
        {
            try
            {
                return regulationDAO.DeleteRule(strRuleId);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
