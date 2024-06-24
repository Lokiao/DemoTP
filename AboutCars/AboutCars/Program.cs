using System;

namespace AboutCars
{
    public class Program
    {
    
        public static void Main(string[] args)
        {
            Car renault = new Gasoline("UN-423-IV", "Renault", "Twingo");
            Car hyundai = new Electrical("KR-132-DD", "Hyundai", "Grandeur");
            CarFeature leather = new CarFeature("Leather seats", 
                "The car has beautiful and comfortable beige leather seats");
            CarFeature goldenRims = new CarFeature("Golden rims", 
                "The car has nice golden rims");
            renault.AddFeature(leather);
            renault.AddFeature(goldenRims);
            //Console.WriteLine(renault.ToString());
            //renault.RemoveFeature(leather);
            //Console.WriteLine(renault.ToString());
            //renault.RemoveFeature(leather);

            Garage Willys = new Garage();
            Willys.AddCar(renault);
            Willys.AddCar(hyundai);
            Willys.Arrange(Order.Noise);
            Console.WriteLine(Willys.ToString());
        }
    }
}