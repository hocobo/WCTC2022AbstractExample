using System;

namespace AbstractExample.Models
{
    public class Snake : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Ssssssssss");
        }

        public override void Sleep()
        {
            Console.WriteLine("SSSSSsssssss");
        }
    }
}