namespace DesignPatternsV1.Behavioral.Memento
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
            System.Console.WriteLine($"Originator: My initial state is: {_state}");
        }

        public void DoSomething()
        {
            System.Console.WriteLine("Originator: I'm doing something important.");
            _state = GenerateRandomString(30);
            System.Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                length--;
            }

            return result;
        }

        public Memento Save()
        {
            return new Memento(_state);
        }

        public void Restore(Memento memento)
        {
            _state = memento.GetState();
            System.Console.WriteLine($"Originator: My state has changed to: {_state}");
        }
    }
} 