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
    public class DAOCustomer
    {
        public DAOCustomer()
        {

        }
        /// <summary>
        /// Phương thức lấy tất cả các Customer từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllCustomer()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllCustomer");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
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
                DataExecute.Instance.createSqlCmd("sp_GetCustomerByID"/*Truyen vao storeprocedure*/, new object[1] { strCustomerId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
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
                DataExecute.Instance.createSqlCmd("sp_AddNewCustomerInsert"/*Truyen vao storeprocedure*/, new object[8] { Customer.CustomerID, Customer.Name, Customer.Gender, Customer.Birthday, Customer.Address, Customer.Phone, Customer.Email, Customer.NumberID});
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
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
                DataExecute.Instance.createSqlCmd("sp_EditCustomerUpdate"/*Truyen vao storeprocedure*/, new object[8] { Customer.CustomerID, Customer.Name, Customer.Gender, Customer.Birthday, Customer.Address, Customer.Phone, Customer.Email, Customer.NumberID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
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
                DataExecute.Instance.createSqlCmd("sp_DeleteCustomer"/*Truyen vao storeprocedure*/, new object[1] { strCustomerId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtCustomerByNameFromDatabase(String strCustomerName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtCustomerByNameDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strCustomerName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
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
                DataExecute.Instance.createSqlCmd("sp_LookAtCustomerByIdDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strCustomerId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strOrderID"></param>
        /// <returns></returns>
        public String GetCustomerByOrderDetailId(String strOrderID)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetCustomerByOrderID"/*Truyen vao storeprocedure*/, new object[1] { strOrderID });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
    }
}