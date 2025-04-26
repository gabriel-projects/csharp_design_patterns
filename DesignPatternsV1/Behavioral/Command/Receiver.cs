namespace DesignPatternsV1.Behavioral.Command
{
    public class Receiver
    {
        public string DoSomething(string a)
        {
            return $"Receiver: Working on ({a}.)";
        }

        public string DoSomethingElse(string b)
        {
            return $"Receiver: Also working on ({b}.)";
        }
    }
} 