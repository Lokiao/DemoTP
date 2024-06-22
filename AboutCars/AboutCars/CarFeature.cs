// CarFeature.cs
namespace AboutCars
{
    public class CarFeature
    {
        //We assume that there is only one description per feature.
        public string FeatureName { get; set; }
        public string FeatureDescription { get; set; }
        
        public CarFeature(string featureName, string featureDescription)
        {
            FeatureName = featureName;
            FeatureDescription = featureDescription;
        }
    }
}