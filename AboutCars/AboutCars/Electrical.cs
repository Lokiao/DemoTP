namespace AboutCars
{
    public class Electrical : Car
    {
        public Electrical(string licenseNumber, string brand, string model, double maxSpeed=200, double accel=16.667, int noise=20)
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