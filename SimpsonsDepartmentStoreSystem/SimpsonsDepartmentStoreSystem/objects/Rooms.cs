using System;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Rooms
    {
        int roomNumber;
        bool nailBar;

        public Rooms()
        {
            RoomNumber = 0;
            NailBar = false;
        }

        public Rooms(int roomNumber, bool nailBar)
        {
            RoomNumber = roomNumber;
            NailBar = nailBar;
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public bool NailBar
        {
            get { return nailBar; }
            set { nailBar = value; }
        }
    }
}
