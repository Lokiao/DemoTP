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
        void Arrange(Order order);
        Car FindBestCar(Track track);

        string ToString();
    }
}