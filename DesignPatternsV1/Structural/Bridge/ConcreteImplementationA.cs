namespace DesignPatternsV1.Structural.Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.";
        }
    }
} 