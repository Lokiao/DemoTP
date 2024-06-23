namespace AboutCars
{
    public enum Order
    {
        BM,         //brand and model
        Speed,
        Noise
    }
    
    public interface IGarage
    {
        Car[] Arrange(Car[] cars, Order order);
        Car FindBestCar(Car[] cars, Track track);
    }
}