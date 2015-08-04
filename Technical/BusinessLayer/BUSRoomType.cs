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
    public class BUSRoomType
    {
        private DAORoomType roomTypeDAO;

        public BUSRoomType()
        {
            roomTypeDAO = new DAORoomType();
        }

        /// <summary>
        /// Phương thức lấy tất cả các RoomType từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllRoomType()
        {
            try
            {
                return roomTypeDAO.GetAllRoomType();
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
                return roomTypeDAO.GetRoomTypeById(strRoomTypeId);
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
                return roomTypeDAO.InsertRoomType(RoomType);
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
                return roomTypeDAO.UpdateRoomType(RoomType);
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
                return roomTypeDAO.DeleteRoomType(strRoomTypeId);
            }
            catch (SqlException)
            {

                throw;
            }
        }

        public DataTable LookAtRoomType(String strRoomTypeId)
        {
            try
            {
                return roomTypeDAO.LookAtRoomType(strRoomTypeId);
            }
            catch (SqlException)
            {

                throw;
            }
        }
    }
}
