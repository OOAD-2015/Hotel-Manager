using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLayer
{
    public class BUSOrder
    {
        private DAOOrder orderDAO = new DAOOrder();
        /// <summary>
        /// Phương thức lấy tất cả các Room từ csdl
        /// </summary>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetAllOrder()
        {
            return orderDAO.GetAllOrder();
        }

        /// <summary>
        /// Phương thức lấy Order theo id của Room
        /// </summary>
        /// <param name="strOrderID">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public DataTable GetOrderById(String strOrderID)
        {
            return orderDAO.GetOrderById(strOrderID);

        }
        /// <summary>
        /// Phương thức lấy Order theo id của Room
        /// </summary>
        /// <param name="strOrderLabel">id của feedback</param>
        /// <returns>true: lấy thành công, false: lấy thất bại</returns>
        public String GetOrderByLabel(String strOrderLabel)
        {
            return orderDAO.GetOrderByLabel(strOrderLabel);

        }

        /// <summary>
        /// Phương thức thêm mới một Order vào csdl
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool InsertOrder(DTOOrder dtoOrder)
        {
            return orderDAO.InsertOrder(dtoOrder);
        }
        /// <summary>
        /// Phương thức cập nhật một Order xuống csdl theo id
        /// </summary>
        /// <returns>true: thêm mới thành công, false: thêm mới thất bại</returns>
        public bool UpdateOrder(DTOOrder dtoOrder)
        {
            return orderDAO.UpdateOrder(dtoOrder);
        }

        public bool DeteleOrder(string orderID)
        {
            return orderDAO.DeleteOrder(orderID);
        }

        public string GetOrderMaxID()
        {
            return orderDAO.GetOrderMaxID();
        }
    }
}
