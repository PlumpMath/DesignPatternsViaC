using System;

namespace Builder
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}