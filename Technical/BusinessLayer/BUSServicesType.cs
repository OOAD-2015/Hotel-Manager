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
    public class BUSServicesType
    {
        private DAOServicesType servicesTypeDAO;

        public BUSServicesType()
        {
            servicesTypeDAO = new DAOServicesType();
        }

        /// <summary>
        /// Phương thức lấy tất cả các ServicesType từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllServicesType()
        {
            try
            {
                return servicesTypeDAO.GetAllServicesType();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy ServicesType theo id của ServicesType
        /// </summary>
        /// <param name="iServicesTypeId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetServicesTypeById(String strServicesTypeId)
        {
            try
            {
                return servicesTypeDAO.GetServicesTypeById(strServicesTypeId);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một ServicesType vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertServicesType(DTOServicesType ServicesType)
        {
            try
            {
                return servicesTypeDAO.InsertServicesType(ServicesType);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một ServicesType xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateServicesType(DTOServicesType ServicesType)
        {
            try
            {
                return servicesTypeDAO.UpdateServicesType(ServicesType);
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một ServicesType theo id
        /// </summary>
        /// <param name="iServicesTypeId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteServicesType(String strServicesTypeId)
        {
            try
            {
                return servicesTypeDAO.DeleteServicesType(strServicesTypeId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtServicesType(String strServicesTypeId)
        {
            try
            {
                return servicesTypeDAO.LookAtServicesType(strServicesTypeId);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
