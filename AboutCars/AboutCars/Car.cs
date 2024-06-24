using System;
using System.Collections.Generic;
using System.Threading;

namespace AboutCars
{   
    public abstract class Car : ICar
    {
        public string LicenseNumber { get; protected set; }
        
        public string Brand { get; protected set; }

        public string Model { get; protected set; }

        public double MaxSpeed { get; protected set; }
        
        public double Acceleration { get; protected set; }

        public double Speed { get; set; } = 0;
        
        public int Noise { get; set; }
        
        public List<CarFeature> Features { get; } = new List<CarFeature>();

        /// <summary>
        /// Willy the garagist wants to add new personalized features to this car.
        /// </summary>
        /// <param name="feature">The feature to be implemented</param>
        /// <remarks>
        /// Do not add the same feature twice.
        /// </remarks>
        public void AddFeature(CarFeature feature)
        {
            if (Features.Contains(feature))
                throw new Exception("Willy... I think this car has already this feature...");
            Features.Add(feature);
        }

        /// <summary>
        /// Willy the garagist wants to remove a feature from this car.
        /// </summary>
        /// <param name="feature">The feature to be removed</param>
        /// <remarks>
        /// Check that it exists.
        /// </remarks>
        public void RemoveFeature(CarFeature feature)
        {
            if (!Features.Contains(feature))
                throw new Exception("Willy, this car does not have this feature...");
            Features.Remove(feature);
        }

        /// <summary>
        /// Simply a ToString function to implement in the children classes.
        /// </summary>
        /// <returns>
        /// A string.
        /// </returns>
        public abstract override string ToString();

        /// <summary>
        /// Willy the garagist would like to estimate the time that this car would take to finish this track.
        /// </summary>
        /// <param name="track">The track where the race will happen</param>
        /// <returns>
        /// The time in seconds for the car to finish the track.
        /// </returns>
        /// <remarks>
        /// Always round up the number, better to overestimate than to underestimate
        /// </remarks>
        public double TimeToFinish(Track track)
        {
            throw new NotImplementedException();
        }

        public void Race()
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine($"Hello Everyone, we're here today in Seoul to watch the battle of the century.");
            Thread.Sleep(500);
            Console.WriteLine($"Please applaud the {Brand} {Model} going against the unkillable demon king, flash...");
            Thread.Sleep(1000);
            Console.WriteLine("MCQUEEN!!!");
            Thread.Sleep(1500);
            Console.WriteLine("The race is starts in: ");
            Thread.Sleep(500);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!");
            Thread.Sleep(1000);
            
        }
    }

}