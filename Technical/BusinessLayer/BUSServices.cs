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
    public class BUSServices
    {
          private DAOServices servicesDAO;

        public BUSServices()
        {
            servicesDAO = new DAOServices();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Services từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllServices()
        {
            try
            {
                return servicesDAO.GetAllServices();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy Services theo id của Services
        /// </summary>
        /// <param name="iServicesId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServicesById(String strServicesId)
        {
            try
            {
                return servicesDAO.GetServicesById(strServicesId);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public DataTable GetDataServicesById(String strServicesId)
        {
            try
            {
                return servicesDAO.GetDataServicesById(strServicesId);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Services theo id của Services
        /// </summary>
        /// <param name="iServicesId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetServicesByLabel(String strServicesLabel)
        {
            try
            {
                return servicesDAO.GetServicesByLabel(strServicesLabel);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức thêm mới một Services vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertServices(DTOServices Services)
        {
            try
            {
                return servicesDAO.InsertServices(Services);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một Services xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateServices(DTOServices Services)
        {
            try
            {
                return servicesDAO.UpdateServices(Services);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một Services theo id
        /// </summary>
        /// <param name="iServicesId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteServices(String strServicesId)
        {
            try
            {
                return servicesDAO.DeleteServices(strServicesId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtServices(String strServicesId)
        {
            try
            {
                return servicesDAO.LookAtServices(strServicesId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public bool CheckServiceIsExistInDatabase(String strServiceId)
        {
            DataTable temp = servicesDAO.GetDataServicesById(strServiceId);
            if (temp != null)
            {
                if (temp.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
