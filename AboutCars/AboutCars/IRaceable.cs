namespace AboutCars
{
    public class Track
    {
        private int nbOfTurns;
        
        private double[] kmBtwEachTurn;

        public Track(int nbOfTurns, double[] kmBtwEachTurn)
        {
            this.nbOfTurns = nbOfTurns;
            this.kmBtwEachTurn = kmBtwEachTurn;
        }
    }
    
    public interface ICar
    {
        void AddFeature(CarFeature feature);
        void RemoveFeature(CarFeature feature);
        double TimeToFinish(Track track);
        void Race();
        string ToString();
    }
}