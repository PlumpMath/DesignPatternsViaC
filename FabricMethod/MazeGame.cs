namespace FabricMethod
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var aMaze = MakeMaze();
            var r1 = MakeRoom(1);
            var r2 = MakeRoom(2);
            var theDoor = MakeDoor(r1, r2);
            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);
            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.West, MakeWall());

            r1.SetSide(Direction.North, MakeWall());
            r1.SetSide(Direction.West, theDoor);
            r1.SetSide(Direction.South, MakeWall());
            r1.SetSide(Direction.East, MakeWall());
            return aMaze;
        }

        public virtual MapSite MakeWall()
        {
            return new Wall();
        }

        public virtual MapSite MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }

        public virtual Room MakeRoom(int p0)
        {
            return new Room(p0);
        }

        public virtual Maze MakeMaze()
        {
            return new Maze();
        }
    }
}