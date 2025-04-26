namespace DesignPatternsV1.Structural.Bridge
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            _implementation = implementation;
        }

        public virtual string Operation()
        {
            return $"Abstraction: Base operation with:\n{_implementation.OperationImplementation()}";
        }
    }
} 