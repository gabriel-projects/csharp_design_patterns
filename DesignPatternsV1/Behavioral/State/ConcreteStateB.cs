namespace DesignPatternsV1.Behavioral.State
{
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            System.Console.WriteLine("ConcreteStateB handles request.");
            System.Console.WriteLine("ConcreteStateB wants to change the state of the context.");
            context.TransitionTo(new ConcreteStateA());
        }
    }
} 