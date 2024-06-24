using System;
using System.Linq;

namespace AboutCars
{
    public class TestSuite
    {
        private static bool FeatConst ()
        {
            CarFeature carFeature = new CarFeature("Test", "Test1");
            return carFeature.FeatureDescription == "Test1" && carFeature.FeatureName == "Test";
        }

        private static bool CarConst ()
        {
            Car car1 = new Gasoline("random5", "Dacia", "5X");
            Car car2 = new Gasoline("random5", "Dacia", "5X", 5, 7, 50);
            Car car3 = new Electrical("random5", "Dacia", "5X");
            Car car4 = new Electrical("random5", "Dacia", "5X", 5, 7, 50);
            bool b = car1.Brand == car2.Brand && car3.Brand == car4.Brand;
            b &= car1.Brand == car4.Brand;
            b &= car1.Model == car2.Model && car3.Model == car4.Model;
            b &= car1.Model == car4.Model;
            b &= car1.LicenseNumber == car2.LicenseNumber && car3.LicenseNumber == car4.LicenseNumber;
            b &= car1.LicenseNumber == car4.LicenseNumber;
            b &= car2.MaxSpeed == car4.MaxSpeed;
            b &= car2.Acceleration == car4.Acceleration;
            b &= car2.Noise == car4.Noise;
            b &= car1.Noise == 80 && car1.MaxSpeed == 220 && car1.Speed == 0 && car1.Acceleration == 14.286 && car1.Model == "5X" && car1.Brand == "Dacia" && car1.LicenseNumber == "random5";
            b &= car3.Noise == 20 && car3.MaxSpeed == 200 && car3.Speed == 0 && car3.Acceleration == 16.667 && car3.Features.Count == 0;
            return b && car1.Features.Count == 0;
        }

        private static bool AddAndRemoveFeatTest(Car car)
        {
            CarFeature t = new CarFeature("hey", "its late xd");
            CarFeature t2 = new CarFeature("Not the same", "its late xd");
            bool b = true;
            try
            {
                car.AddFeature(t);
                b &= car.Features.Count == 1 && car.Features[0].FeatureName == "hey" &&
                     car.Features[0].FeatureDescription == "its late xd";
                
                car.AddFeature(t2);
                b &= car.Features.Count == 2;
                if (!b)
                    return false;
                car.AddFeature(t2);
            }
            catch (Exception e)
            {
                b &= e.Message == "Willy... I think this car has already this feature...";
            }

            car.RemoveFeature(t2);
            b &= car.Features.Count == 1 && car.Features[0].FeatureDescription == "its late xd";
            
            try
            {
                car.RemoveFeature(t2);
                return false;
            }
            catch (Exception e)
            {
                b &= e.Message == "Willy, this car does not have this feature...";
                
             
            }

            return b;
        }
        
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
            //Console.WriteLine(Willys.ToString());
            Console.WriteLine(FeatConst());
            Console.WriteLine(CarConst());
            Console.WriteLine(AddAndRemoveFeatTest(hyundai));
        }
    }
}