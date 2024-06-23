using System;

namespace AboutCars
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            Car renault = new Gasoline("UN-423-IV","Renault","Twingo");
            Console.WriteLine(renault.ToString());
        }
    }
}