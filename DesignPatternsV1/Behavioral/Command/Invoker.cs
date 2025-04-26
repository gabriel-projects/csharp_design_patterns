using System.Collections.Generic;

namespace DesignPatternsV1.Behavioral.Command
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void DoSomethingImportant()
        {
            if (_onStart is ICommand)
            {
                _onStart.Execute();
            }

            System.Console.WriteLine("Invoker: ...doing something really important...");

            if (_onFinish is ICommand)
            {
                _onFinish.Execute();
            }
        }
    }
} 