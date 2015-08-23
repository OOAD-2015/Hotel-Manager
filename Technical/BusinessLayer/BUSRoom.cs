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
    public class BUSRoom
    {
        private DAORoom roomDAO;

        public BUSRoom()
        {
            roomDAO = new DAORoom();
        }

        /// <summary>
        /// Phương thức lấy tất cả các Room từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRoom()
        {
            try
            {
                return roomDAO.GetAllRoom();
            }
            catch (SqlException)
            {

                throw;
            }
        }
        /// <summary>
        /// Phương thức lấy tất cả các Room từ csdl With Date
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRoomWithDate()
        {
            try
            {
                return roomDAO.GetAllRoomWithDate();
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
                return roomDAO.GetRoomById(strRoomId);
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
                return roomDAO.GetRoomByLabel(strRoomLabel);
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
                return roomDAO.InsertRoom(Room);
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
                return roomDAO.UpdateRoom(Room);
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
                return roomDAO.DeleteRoom(strRoomId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtRoom(String strRoomId)
        {
            try
            {
                return roomDAO.LookAtRoom(strRoomId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable GetAllRoomByDateFromTo(DateTime startDate, DateTime endDate)
        {
            return roomDAO.GetAllRoomByDateFromTo(startDate, endDate);
        }
    }
}
