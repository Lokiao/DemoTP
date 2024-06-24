namespace AboutCars
{
    public class Gasoline : Car
    {
        public Gasoline(string licenseNumber, string brand, string model, double maxSpeed=220, double accel=14.286, int noise=80)
        {
            LicenseNumber = licenseNumber;
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            Acceleration = accel;
            Noise = noise;
        }

        public override string ToString()
        {
            string s = "";
            s += $"This is the gasoline {Brand} {Model} {LicenseNumber}.\nIt can go up to {MaxSpeed}km/h, with an acceleration of {Acceleration}km/h/s.\n";
            if (Noise >= 50)
                s += "Also... it does make some noise...";
            else
                s += "And it's pretty silent!!!";
            if (Features.Count > 0)
            {
                s += $"\nEither way, this car has {Features.Count} features:\n";
                int i = 1;
                foreach (CarFeature feature in Features)
                {
                    s += $"   {i}. {feature.FeatureName} : {feature.FeatureDescription}\n";
                    i++;
                }
            }
            return s;
        }
    }
}