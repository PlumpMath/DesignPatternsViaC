using System;

namespace Prototype
{
    public class Door : MapSite
    {
        private readonly Room room1;
        private readonly Room room2;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }

        public override void Enter()
        {
            Console.WriteLine("Door");
        }

        public Room OtherSideFrom(Room room)
        {
            return room == room1 ? room2 : room1;
        }

        public virtual Door Clone()
        {
            throw new NotImplementedException();
        }

        public virtual void Initialize(Room room, Room room3)
        {
            throw new NotImplementedException();
        }
    }
}