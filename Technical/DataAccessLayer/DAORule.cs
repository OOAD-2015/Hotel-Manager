using DataTransferObject.Extention;
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
namespace DataAccessLayer
{
    public class DAORule
    {
        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public DAORule()
        {
            
        }
        
        /// <summary>
        /// Phương thức lấy tất cả các Rule từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRule()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllRule");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
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
                DataExecute.Instance.createSqlCmd("sp_GetRuleByID"/*Truyen vao storeprocedure*/, new object[1] { strRuleId });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
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
                DataExecute.Instance.createSqlCmd("sp_GetRuleByLabel"/*Truyen vao storeprocedure*/, new object[1] { strRuleLabel });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
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
                DataExecute.Instance.createSqlCmd("sp_AddNewRuleInsert"/*Truyen vao storeprocedure*/, new object[3] { Rule.Id, Rule.Label, Rule.Value});
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
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
                DataExecute.Instance.createSqlCmd("sp_EditRuleUpdate"/*Truyen vao storeprocedure*/, new object[3] { Rule.Id, Rule.Label, Rule.Value });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
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
                DataExecute.Instance.createSqlCmd("sp_DeleteRule"/*Truyen vao storeprocedure*/, new object[1] { strRuleId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {
                
                throw;
            }
        }
    }
}
