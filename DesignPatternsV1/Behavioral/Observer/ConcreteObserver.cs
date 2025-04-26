namespace DesignPatternsV1.Behavioral.Observer
{
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is ConcreteSubject concreteSubject)
            {
                System.Console.WriteLine($"Observer {_name} received update. New state: {concreteSubject.State}");
            }
        }
    }
} 