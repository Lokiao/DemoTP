using System;
using System.Threading;

namespace AboutCars
{
    public abstract class Car
    {
        public string LicenseNumber { get; set; }

        //stats about the cars like maxspeed / accel and turn rate
        public string Brand { get; set; }

        public string Model { get; set; }

        public abstract int Speed { get; }
        public abstract int Noise { get; }
        
        public void Race()
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine($"Hello Everyone, we're here today to watch the battle of the century.");
            Thread.Sleep(500);
            Console.WriteLine($"Please applaud the {Brand} {Model} going against the unkillable demon king, flash...");
            Thread.Sleep(1000);
            Console.WriteLine("MACQUEEN!!!");
            Thread.Sleep(1500);
            Console.WriteLine("The race is starts in: ");
            Thread.Sleep(500);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!");
        }
    }

}