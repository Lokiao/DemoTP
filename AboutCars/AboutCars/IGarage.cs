using System.Collections.Generic;

namespace AboutCars
{
    public enum Order
    {
        None,
        BM,         //brand and model
        Speed,
        Noise
    }
    
    public interface IGarage
    {
        void AddCar(Car car);
        void RemoveCar(Car car);
        void Arrange(Order order);
        Car FindBestCar(Track track);

        string ToString();
    }
}