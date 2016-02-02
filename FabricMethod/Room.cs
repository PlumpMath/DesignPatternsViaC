using System;
using System.Collections.Generic;

namespace FabricMethod
{
    public class Room : MapSite
    {
        private int roomNumber = 0;
        private Dictionary<Direction, MapSite> sides;

        public Room(int roomNo)
        {
            this.roomNumber = roomNo;
            sides = new Dictionary<Direction, MapSite>();
        }

        public override void Enter()
        {
            Console.WriteLine("Room");
        }

        public MapSite GetSide(Direction direction)
        {
            return sides[direction];
        }

        public void SetSide(Direction direction, MapSite mapSide)
        {
            sides.Add(direction, mapSide);
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
    }
}