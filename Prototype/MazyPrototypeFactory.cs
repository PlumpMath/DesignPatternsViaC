namespace Prototype
{
    public class MazyPrototypeFactory : MazeFactory
    {
        private readonly Maze _maze;
        private readonly Wall _wall;
        private readonly Room _room;
        private readonly Door _door;

        public MazyPrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            _maze = maze;
            _wall = wall;
            _room = room;
            _door = door;
        }

        public override Maze MakeMaze()
        {
            return _maze.Clone();
        }

        public override Room MakeRoom(int number)
        {
            var room = _room.Clone();
            room.Initilize(number);
            return room;
        }

        public override Wall MakeWall()
        {
            return _wall.Clone();
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            var door = _door.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}