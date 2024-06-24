namespace AboutCars
{
    public class Track
    {
        public int NbOfTurns { get; private set; }
        public double[] LengthOfTurns { get; private set; } //len(LengthOfTurns) = NbOfTurns
        public double[] KmBtwEachTurn { get; private set; } //len(LengthOfTurns) = NbOfTurns + 2 (start->first and last->finish)

        public Track(int nbOfTurns, double[] lengthOfTurns, double[] kmBtwEachTurn)
        {
            NbOfTurns = nbOfTurns;
            LengthOfTurns = lengthOfTurns;
            KmBtwEachTurn = kmBtwEachTurn;
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