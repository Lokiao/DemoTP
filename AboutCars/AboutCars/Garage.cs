using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace AboutCars
{
    public class Garage : IGarage
    {

        public List<Car> Cars = new List<Car>();

        private Order CurrentOrdering = Order.None;

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Willy the garagist just received a new car, he wants to put it in his garage, but at the right place.
        /// </summary>
        /// <param name="car">The car to be inserted in the List Cars</param>
        /// <remarks>
        /// Use CurrentOrdering to know where to insert the new car.
        /// If CurrentOrdering is None, simply add it at the end of the list.
        /// </remarks>
        public void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Willy the garagist is selling a car, go find it for him.
        /// </summary>
        /// <param name="car">The car to be found in the List Cars</param>
        /// <returns>
        /// The car inside Cars that is equivalent to the car wanted.
        /// </returns>
        /// <remarks>
        /// Use CurrentOrdering to know where to how to find the car quicker.
        /// If CurrentOrdering is None, simply do a linear search.
        /// Attention: We will evaluate the speed of the program.
        /// </remarks>
        public Car PopCar(Car car)
        {
            throw new NetworkInformationException();
        }
        
        /// <summary>
        /// Willy the garagist wants to be able to arrange his garage's cars.
        /// Sometimes he wants them to be ordered by brand and model name,
        /// sometimes by speed or even by noisiness.
        /// Help him out to befriend him.
        /// </summary>
        /// <param name="order">The type of sort that we want</param>
        /// <returns>
        /// A sorted list of cars using the ordering wanted.
        /// </returns>
        /// <remarks>
        /// When ordering by brand and model, it should go from "A" to "Z"
        /// When ordering by speed, make it in decreasing order
        /// When ordering by noise, make it in increasing order
        /// You can do auxiliary functions to help you out.
        /// </remarks>
        public void Arrange(Order order)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Willy the garagist now trusts you (if you did the first function well that is).
        /// However, there will soon be an important race that he wants to win for sure.
        /// All he knows is the length of the race and the number of non-negligeable turns inside it.
        /// He asks you to find the best car you can for this race.
        /// If you do not mess this one up, you should be able to participate in some races with his cars.
        /// </summary>
        /// <param name="track">The track where the race will happen</param>
        /// <returns>
        /// The best car for the race
        /// </returns>
        /// <remarks>
        /// We suppose that during a turn, each car goes at 80km/h (not gradually).
        /// After a turn, the speed of each gradually reaches their maximum speed (if possible).
        /// </remarks>
        public Car FindBestCar(Track track)
        {
            throw new NotImplementedException();
        }
    }
}