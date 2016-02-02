namespace Builder
{
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();
        public abstract void BuildRoom(int roomNo);
        public abstract void BuildDoor(int roomFrom, int roomTo);
        public abstract Maze GetMaze();
    }

    class StandartMazeBuilder : MazeBuilder
    {
        public override void BuildMaze()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildRoom(int roomNo)
        {
            throw new System.NotImplementedException();
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            throw new System.NotImplementedException();
        }

        public override Maze GetMaze()
        {
            throw new System.NotImplementedException();
        }
    }
}