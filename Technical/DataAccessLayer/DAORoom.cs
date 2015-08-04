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
    public class DAORoom
    {
        /// <summary>
        /// Phương thức lấy tất cả các Room từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRoom()
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetAllRoom");
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy Room theo id của Room
        /// </summary>
        /// <param name="iRoomId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetRoomById(String strRoomId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRoomByID"/*Truyen vao storeprocedure*/, new object[1] { strRoomId });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }
        /// <summary>
        /// Phương thức lấy Room theo id của Room
        /// </summary>
        /// <param name="iRoomId">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetRoomByLabel(String strRoomLabel)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_GetRoomByLabel"/*Truyen vao storeprocedure*/, new object[1] { strRoomLabel });
                return DataExecute.Instance.getStringExecute(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Phương thức thêm mới một Room vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertRoom(DTORoom Room)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_AddNewRoomInsert"/*Truyen vao storeprocedure*/, new object[6] { Room.RoomID, Room.RoomName, Room.RoomTypeID, Room.NumberOfBeds, Room.Description, Room.RoomStatusID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức cập nhật một Room xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateRoom(DTORoom Room)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_EditRoomUpdate"/*Truyen vao storeprocedure*/, new object[6] { Room.RoomID, Room.RoomName, Room.RoomTypeID, Room.NumberOfBeds, Room.Description, Room.RoomStatusID });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức xóa một Room theo id
        /// </summary>
        /// <param name="iRoomId"></param>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool DeleteRoom(String strRoomId)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_DeleteRoom"/*Truyen vao storeprocedure*/, new object[1] { strRoomId });
                return DataExecute.Instance.updateData(DataConnection.Instance.m_cmd) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtRoom(String strRoomName)
        {
            try
            {
                DataExecute.Instance.createSqlCmd("sp_LookAtRoomDataFromDatabase"/*Truyen vao storeprocedure*/, new object[1] { strRoomName });
                return DataExecute.Instance.getData(DataConnection.Instance.m_cmd);
            }
            catch (SqlException)
            {

                throw;
            }

        }
    }
}
