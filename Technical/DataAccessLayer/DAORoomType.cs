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
    public class DAORoomType
    {
        /// <summary>
        /// Phương thức lấy tất cả các RoomType từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRoomType()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllRoomType");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy RoomType theo id của RoomType
        /// </summary>
        /// <param name="iRoomTypeId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetRoomTypeById(String strRoomTypeId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRoomTypeByID"/*Truyen vao storeprocedure*/, new object[1] { strRoomTypeId });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một RoomType vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertRoomType(DTORoomType RoomType)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewRoomTypeInsert"/*Truyen vao storeprocedure*/, new object[3] { RoomType.RoomTypeID, RoomType.RoomTypeName, RoomType.Price });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức cập nhật một RoomType xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateRoomType(DTORoomType RoomType)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditRoomTypeUpdate"/*Truyen vao storeprocedure*/, new object[3] { RoomType.RoomTypeID, RoomType.RoomTypeName, RoomType.Price });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }
        /// <summary>
        /// Phương thức xóa một RoomType theo id
        /// </summary>
        /// <param name="iRoomTypeId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteRoomType(String strRoomTypeId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteRoomType"/*Truyen vao storeprocedure*/, new object[1] { strRoomTypeId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }

        }

        public DataTable LookAtRoomType(String strRoomTypeName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtRoomTypeDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strRoomTypeName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
