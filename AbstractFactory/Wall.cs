using System;

namespace AbstractFactory
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}