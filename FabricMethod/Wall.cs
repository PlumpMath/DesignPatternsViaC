﻿using System;

namespace FabricMethod
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}