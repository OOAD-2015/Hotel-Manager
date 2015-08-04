using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTORoomType
    {
        #region "Variable"
        public string roomTypeID;
        public string roomTypeName;
        public decimal price;
        #endregion

        
        #region "properties"
        public String RoomTypeID
        {
            get { return roomTypeID; }
            set { roomTypeID = value; }
        }
        public System.String RoomTypeName
        {
            get { return roomTypeName; }
            set { roomTypeName = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region  "method"
        public DTORoomType(String roomTypeID, String roomTypeName, decimal price)
        {
            this.roomTypeID = roomTypeID;
            this.roomTypeName = roomTypeName;
            this.price = price;
        }
        public DTORoomType(String roomTypeID, String roomTypeName)
        {
            this.roomTypeID = roomTypeID;
            this.roomTypeName = roomTypeName;
        }
        public DTORoomType(String roomTypeName)
        {
            this.roomTypeName = roomTypeName;
        }
        public DTORoomType()
        {

        }
        #endregion
    }
}
