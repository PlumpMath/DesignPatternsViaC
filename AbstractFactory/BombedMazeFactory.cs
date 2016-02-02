namespace AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }
    }

    public class BombedWall : Wall
    {
    }

    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int number) : base(number)
        {
            
        }
    }
}