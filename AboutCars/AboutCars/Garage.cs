using System;

namespace AboutCars
{
    public class Garage : IGarage
    {
        /// <summary>
        /// Willy the garagist wants to be able to arrange his garage's cars.
        /// Sometimes he wants them to be ordered by brand and model name,
        /// sometimes by speed or even by noisyness.
        /// Help him out to befriend him.
        /// </summary>
        /// <param name="cars">The list of the cars to be sorted</param>
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
        public Car[] Arrange(Car[] cars, Order order)
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
        /// <param name="cars">The list of the different cars</param>
        /// <param name="track">The track where the race will happen</param>
        /// <returns>
        /// The best car for the race
        /// </returns>
        /// <remarks>
        /// We suppose that during a turn, each car goes at 80km/h (not gradually).
        /// After a turn, the speed of each gradually reaches their maximum speed (if possible).
        /// </remarks>
        public Car FindBestCar(Car[] cars, Track track)
        {
            throw new NotImplementedException();
        }
    }
}