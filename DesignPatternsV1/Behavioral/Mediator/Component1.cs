namespace DesignPatternsV1.Behavioral.Mediator
{
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            System.Console.WriteLine("Component 1 does A.");
            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            System.Console.WriteLine("Component 1 does B.");
            _mediator.Notify(this, "B");
        }
    }
} 