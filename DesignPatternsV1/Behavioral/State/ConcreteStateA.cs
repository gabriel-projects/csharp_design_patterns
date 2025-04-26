namespace DesignPatternsV1.Behavioral.State
{
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            System.Console.WriteLine("ConcreteStateA handles request.");
            System.Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            context.TransitionTo(new ConcreteStateB());
        }
    }
} 