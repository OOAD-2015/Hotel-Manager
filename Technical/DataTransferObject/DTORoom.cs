using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTORoom
    {
        #region "Variable"
        public string roomID;
        public string roomName;
        public string roomTypeID;
        public int numberOfBeds;
        public string description;
        public string roomStatusID;
        #endregion

        #region "properties"
        public String RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public System.String RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public System.String RoomTypeID
        {
            get { return roomTypeID; }
            set { roomTypeID = value; }
        }
        public int NumberOfBeds
        {
            get { return numberOfBeds; }
            set { numberOfBeds = value; }
        }
        public System.String Description
        {
            get { return description; }
            set { description = value; }
        }
        public System.String RoomStatusID
        {
            get { return roomStatusID; }
            set { roomStatusID = value; }
        }
        #endregion

        #region  "method"
        public DTORoom(string roomID, string roomName, string roomTypeID, int numberOfBeds, string description, string roomStatusID)
        {
            this.roomID = roomID;
            this.roomName = roomName;
            this.roomTypeID = roomTypeID;
            this.numberOfBeds = numberOfBeds;
            this.description = description;
            this.roomStatusID = roomStatusID;
        }
        public DTORoom()
        {

        }
        #endregion
    }
}
