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
            throw new System.NotImplementedException();
        }
    }
}