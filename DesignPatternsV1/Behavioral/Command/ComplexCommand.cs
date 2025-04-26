namespace DesignPatternsV1.Behavioral.Command
{
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;
        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute()
        {
            System.Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            System.Console.WriteLine(_receiver.DoSomething(_a));
            System.Console.WriteLine(_receiver.DoSomethingElse(_b));
        }
    }
} 