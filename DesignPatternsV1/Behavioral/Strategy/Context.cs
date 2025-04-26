namespace DesignPatternsV1.Behavioral.Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public object ExecuteStrategy(object data)
        {
            return _strategy.DoAlgorithm(data);
        }
    }
} 