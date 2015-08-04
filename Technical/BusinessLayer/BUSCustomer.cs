using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using DataTransferObject;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class BUSCustomer
    {
        public DAOCustomer customerDAO;

        public BUSCustomer()
        {
            this.customerDAO = new DAOCustomer();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Customer từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllCustomer()
        {
            try
            {
                return customerDAO.GetAllCustomer();
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Customer theo id của Customer
        /// </summary>
        /// <param name="iCustomerId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetCustomerById(String strCustomerId)
        {
            try
            {
                return customerDAO.GetCustomerById(strCustomerId);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức thêm mới một Customer vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertCustomer(DTOCustomer Customer)
        {
            try
            {
                return customerDAO.InsertCustomer(Customer);
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức cập nhật một Customer xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateCustomer(DTOCustomer Customer)
        {
            try
            {
                return customerDAO.UpdateCustomer(Customer);
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức xóa một Customer theo id
        /// </summary>
        /// <param name="iCustomerId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteCustomer(String strCustomerId)
        {
            try
            {
                return customerDAO.DeleteCustomer(strCustomerId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtCustomerByIdDataFromDatabase(String strCustomerId)
        {
            try
            {
                return customerDAO.LookAtCustomerByIdDataFromDatabase(strCustomerId);
            }
            catch (SqlException)
            {

                throw;
            }

        }

        public DataTable LookAtCustomerByNameDataFromDatabase(String strCustomerName)
        {
            try
            {
                return customerDAO.LookAtCustomerByNameFromDatabase(strCustomerName);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
