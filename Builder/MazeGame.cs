namespace Builder
{
    public class MazeGame
    {
        public Maze CreateMze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
            return builder.GetMaze();
        }
    }
}