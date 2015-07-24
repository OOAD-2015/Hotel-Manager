using DataTransferObject;
using DataTransferObject.Extention;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable getAllData()
        {
            DataExecute.Instance.createSqlCmd("GetAllCustomer");

            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        /// <summary>
        /// Neu muon lay len ma can dieu kien DataExecute.Instance.createSqlCmd(""/*Truyen vao storeprocedure*/, Object[condition1, condition2...])
        /// Hoac  DataExecute.Instance.createSqlCmd(""/*Truyen vao storeprocedure*/,DTOObject)
        /// Lay khong co dieu kien  DataExecute.Instance.createSqlCmd("")
        /// "": la ten store
        /// </summary>
        /// <returns>Tra ve mot SqlCommand, tuc la giong mot cau lenh trong SQL</returns> tao muon lay dua vao ten cua cardtype co ma????
        public DataTable getCustomerName()
        {
            DataExecute.Instance.createSqlCmd("GetCustomerName"/*Truyen vao storeprocedure*/);
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public DataTable getCustomerIDByName(string customerName)
        {
            DataExecute.Instance.createSqlCmd("GetCustomerIDByName"/*Truyen vao storeprocedure*/, new object[1] { customerName });
            return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
        }

        public int updateData(DTOCustomer _dtoCustomer)
        {
            DataExecute.Instance.createSqlCmd("UpdateCustomer", ref _dtoCustomer);
            return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
        }

        public int deleteData(string customerID)
        {
            DataExecute.Instance.createSqlCmd("DeleteCustomer", new object[1] { customerID });
            return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
        }

        public int insertData(DTOCustomer _dtoCustomer)
        {
            DataExecute.Instance.createSqlCmd("InsertCustomer", ref _dtoCustomer);
            return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd);
        }
    }
}