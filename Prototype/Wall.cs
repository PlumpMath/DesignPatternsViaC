using System;

namespace Prototype
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }

        public void Initilize(int number)
        {
            throw new NotImplementedException();
        }

        public virtual Wall Clone()
        {
            throw new NotImplementedException();
        }
    }
}