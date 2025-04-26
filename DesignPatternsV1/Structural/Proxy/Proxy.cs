namespace DesignPatternsV1.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();
                LogAccess();
            }
        }

        private bool CheckAccess()
        {
            System.Console.WriteLine("Proxy: Checking access prior to firing a real request.");
            return true;
        }

        private void LogAccess()
        {
            System.Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
} 