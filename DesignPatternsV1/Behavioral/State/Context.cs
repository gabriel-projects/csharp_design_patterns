namespace DesignPatternsV1.Behavioral.State
{
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(IState state)
        {
            System.Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            _state = state;
            _state.Handle(this);
        }
    }
} 