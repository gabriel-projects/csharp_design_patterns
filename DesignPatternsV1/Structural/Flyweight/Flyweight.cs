namespace DesignPatternsV1.Structural.Flyweight
{
    public class Flyweight
    {
        private string _sharedState;

        public Flyweight(string sharedState)
        {
            _sharedState = sharedState;
        }

        public void Operation(string uniqueState)
        {
            System.Console.WriteLine($"Flyweight: Displaying shared ({_sharedState}) and unique ({uniqueState}) state.");
        }
    }
} 