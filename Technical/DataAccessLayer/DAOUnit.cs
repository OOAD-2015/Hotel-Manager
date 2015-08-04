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
    public class DAOUnit
    {
        /// <summary>
        /// Phương thức lấy tất cả các Unit từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllUnit()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllUnit");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Unit theo id của Unit
        /// </summary>
        /// <param name="iUnitId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetUnitById(String strUnitId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetUnitByID"/*Truyen vao storeprocedure*/, new object[1] { strUnitId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một Unit vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertUnit(DTOUnit Unit)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewUnitInsert"/*Truyen vao storeprocedure*/, new object[2] { Unit.UnitID, Unit.UnitName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức cập nhật một Unit xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateUnit(DTOUnit Unit)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditUnitUpdate"/*Truyen vao storeprocedure*/, new object[2] { Unit.UnitID, Unit.UnitName });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức xóa một Unit theo id
        /// </summary>
        /// <param name="iUnitId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteUnit(String strUnitId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteUnit"/*Truyen vao storeprocedure*/, new object[1] { strUnitId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }

        public DataTable LookAtUnit(String strUnitName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtUnitDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strUnitName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
