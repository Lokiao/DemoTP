using System;

namespace AboutCars
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            Car c1 = new Gasoline("","","");
            c1.Race();
            Console.WriteLine(c1.Model);
        }
    }
}