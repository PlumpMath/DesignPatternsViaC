using System.Collections.Generic;

namespace Builder
{
    public class Maze
    {
        private Dictionary<int, Room> rooms = null;

        public Maze()
        {
            rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int number)
        {
            return rooms[number];
        }
    }
}