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
    public class BUSServiceDetail
    {
        private DAOServiceDetail servicesDAO;

        public BUSServiceDetail()
        {
            servicesDAO = new DAOServiceDetail();
        }

        /// <summary>
        /// Phương thức lấy tất cả các ServiceDetail từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllServiceDetail()
        {
            try
            {
                return servicesDAO.GetAllServiceDetail();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy ServiceDetail theo id của ServiceDetail
        /// </summary>
        /// <param name="iServiceDetailId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServiceDetailById(String strServiceDetailId)
        {
            try
            {
                return servicesDAO.GetServiceDetailById(strServiceDetailId);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy ServiceDetail theo id của ServiceDetail
        /// </summary>
        /// <param name="iServiceDetailId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServiceDetailByLabel(String strServiceDetailLabel)
        {
            try
            {
                return servicesDAO.GetServiceDetailByLabel(strServiceDetailLabel);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức thêm mới một ServiceDetail vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertServiceDetail(DTOServiceDetail ServiceDetail)
        {
            try
            {
                return servicesDAO.InsertServiceDetail(ServiceDetail);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một ServiceDetail xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateServiceDetail(DTOServiceDetail ServiceDetail)
        {
            try
            {
                return servicesDAO.UpdateServiceDetail(ServiceDetail);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một ServiceDetail theo id
        /// </summary>
        /// <param name="iServiceDetailId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteServiceDetail(String strServiceDetailId)
        {
            try
            {
                return servicesDAO.DeleteServiceDetail(strServiceDetailId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllServiceDetailByOrderID(String strOrderID)
        {
            try
            {
                return servicesDAO.GetAllServiceDetailByOrderID(strOrderID);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strServiceDetailId"></param>
        /// <returns></returns>
        public bool DeleteAllServiceDetailByOrderID(String strOrderDetailId)
        {
            try
            {
                return servicesDAO.DeleteAllServiceDetailByOrderID(strOrderDetailId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

    }
}
