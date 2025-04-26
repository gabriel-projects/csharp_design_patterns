namespace DesignPatternsV1.Behavioral.Mediator
{
    public class Component2 : BaseComponent
    {
        public void DoC()
        {
            System.Console.WriteLine("Component 2 does C.");
            _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            System.Console.WriteLine("Component 2 does D.");
            _mediator.Notify(this, "D");
        }
    }
} 