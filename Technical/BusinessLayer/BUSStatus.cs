using DataAccessLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BUSStatus
    {
         private DAOStatus statusDAO;

        public BUSStatus()
        {
            statusDAO = new DAOStatus();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Status từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllStatus()
        {
            try
            {
                return statusDAO.GetAllStatus();
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
                return statusDAO.GetStatusById(strStatusId);
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
                return statusDAO.InsertStatus(Status);
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
                return statusDAO.UpdateStatus(Status);
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
                return statusDAO.DeleteStatus(strStatusId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtStatus(String strStatusId)
        {
            try
            {
                return statusDAO.LookAtStatus(strStatusId);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
