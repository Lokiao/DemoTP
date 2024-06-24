using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;

namespace AboutCars
{
    public class Garage : IGarage
    {

        public List<Car> Cars = new List<Car>();

        private Order CurrentOrdering = Order.None;

        public override string ToString()
        {
            string s = "";
            s += "This is Willy's garage.\n";
            if (Cars.Count == 0)
                s += "There are no cars here for the moment.";
            else
            {
                s += $"The are {Cars.Count} cars in the garage. Please look here:\n\n";
                foreach (Car car in Cars)
                    s += "- " + car + "\n";
            }

            return s;
        }
        
        private int IndexBySpeed(double speed)
        {
            int min = 0;
            int max = Cars.Count - 1;
            while (min <=max)
            {
                int mid = (min + max) / 2;
                if (speed == Cars[mid].MaxSpeed)
                {
                    return mid;
                }
                if (speed > Cars[mid].MaxSpeed)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return min;
        }
        
        private int IndexByNoise(int noise)
        {
            int min = 0;
            int max = Cars.Count - 1;
            while (min <=max)
            {
                int mid = (min + max) / 2;
                if (noise == Cars[mid].Noise)
                {
                    return mid;
                }
                if (noise < Cars[mid].Noise)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return min;
        }

        private bool SupString(string s1, string s2)
        {
            int i = 0;
            while (i < s1.Length && i < s2.Length)
            {
                if (s1[i] == s2[i])
                    i++;
                else
                    return s1[i] > s2[i];
            }

            return i == s2.Length && i < s1.Length;
        }

        private int IndexByM(string brand, string model, int place, int notAgain)
        {
            if (model == Cars[place].Model)
                return ++place;
            if (SupString(model, Cars[place].Model))
            {
                if (place + 1 == notAgain)
                    return notAgain;
                notAgain = place;
                place++;
                if (place < Cars.Count && brand == Cars[place].Brand)
                    return IndexByM(brand, model, place, notAgain);
                return place;
            }

            if (place - 1 == notAgain)
                return place;
            notAgain = place;
            place--;
            if (place >= 0 && brand == Cars[place].Brand)
                return IndexByM(brand, model, place, notAgain);
            return place;
        }
        private int IndexByBM(string brand, string model)
        {
            int min = 0;
            int max = Cars.Count - 1;
            while (min <=max)
            {
                int mid = (min + max) / 2;
                if (brand == Cars[mid].Brand)
                {
                    return IndexByM(brand, model, mid, mid);
                }
                if (SupString(brand, Cars[mid].Brand))
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return min;
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
            switch (CurrentOrdering)
            {
                case Order.None:
                    Cars.Add(car);
                    break;
                case Order.BM:
                    Cars.Insert(IndexByBM(car.Brand, car.Model), car);
                    break;
                case Order.Speed:
                    Cars.Insert(IndexBySpeed(car.MaxSpeed), car);
                    break;
                case Order.Noise:
                    Cars.Insert(IndexByNoise(car.Noise), car);
                    break;
            }
        }
        
        /// <summary>
        /// Willy the garagist is selling a car, take it out of the garage.
        /// </summary>
        /// <param name="car">The car to be removed from the List Cars</param>
        public void RemoveCar(Car car)
        {
            if (Cars.Contains(car))
                Cars.Remove(car);
            else
                throw new Exception("We don't have the car anymore...");
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

        private bool IsLess (Car c1, Car c2, Order order)
        {
            switch (order)
            {
                case Order.None:
                    return false;
                case Order.BM:
                    if (c1.Brand == c2.Brand)
                        return !SupString(c1.Model, c2.Model);
                    return !SupString(c1.Brand, c2.Brand);
                case Order.Speed:
                    return c1.MaxSpeed > c2.MaxSpeed;
                case Order.Noise:
                    return c1.Noise < c2.Noise;
            }

            return false;
        }
        
        public void Arrange (Order order)
        {
            CurrentOrdering = order;
            for (int i = 0; i < Cars.Count(); i++)
            {
                Car minC = Cars[i];
                int minI = i;
                for (int j = i + 1; j < Cars.Count(); j++)
                {
                    if (IsLess(Cars[j], minC, order))
                    {
                        minC = Cars[j];
                        minI = j;
                    }
                }
                (Cars[i], Cars[minI]) = (Cars[minI], Cars[i]);
            }            
        }

        /// <summary>
        /// Willy the garagist now trusts you (if you did the first functions well that is).
        /// However, there will soon be an important race that he wants to win for sure.
        /// All he knows is the length of the race and the number of non-negligible turns inside it.
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