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
    public class BUSUnit
    {
         private DAOUnit unitDAO;

        public BUSUnit()
        {
            unitDAO = new DAOUnit();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Unit từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllUnit()
        {
            try
            {
                return unitDAO.GetAllUnit();
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
                return unitDAO.GetUnitById(strUnitId);
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
                return unitDAO.InsertUnit(Unit);
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
                return unitDAO.UpdateUnit(Unit);
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
                return unitDAO.DeleteUnit(strUnitId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtUnit(String strUnitId)
        {
            try
            {
                return unitDAO.LookAtUnit(strUnitId);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
