using System;

namespace Lab2.Model
{
    public static class Storage
    {
        public static Studio[] Room { get; private set; }
        static Storage()
        {
            Room = new Studio[0];
        }

        public static void AddRoom(Studio studio)
        {
            if (studio == null)
                throw new ArgumentNullException("studio");
            var tmp = new Studio[Room.Length + 1];
            Array.Copy(Room, tmp, Room.Length);
            tmp[tmp.Length - 1] = studio;
            Room = tmp;
            
        }
        public static void CloneRoom(Studio studio)
        {
            if (studio == null)
                throw new ArgumentNullException("room");
            var tmp = new Studio[Room.Length + 1];
            Array.Copy(Room, tmp, Room.Length);
            tmp[tmp.Length - 1] = studio;
            Room = tmp;
        }

        public static void RemoveRoomByIndex(int index, Studio studio)
        {
            if (studio.Workers_count > 0 || studio.Instruments > 0)
                throw new IndexOutOfRangeException("Удалять можно только комнаты без " +
                                                  "инструментов и сотрудников");
            if (index < 0 || index >= Room.Length)
                throw new IndexOutOfRangeException("index");
            
            var tmp = new Studio[Room.Length - 1];
            Array.Copy(Room, 0, tmp, 0, index);
            Array.Copy(Room, index + 1, tmp, index, Room.Length - index - 1);
            Room = tmp;
        }

    }
}
