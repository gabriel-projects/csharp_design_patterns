using System;
using System.Collections.Generic;

namespace DesignPatternsV1.Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Behavioral Design Patterns\n");

            DemonstrateChainOfResponsibility();
            DemonstrateCommand();
            DemonstrateInterpreter();
            DemonstrateIterator();
            DemonstrateMediator();
            DemonstrateMemento();
            DemonstrateObserver();
            DemonstrateState();
            DemonstrateStrategy();
            DemonstrateTemplateMethod();
            DemonstrateVisitor();

            Console.WriteLine("\nAll patterns demonstrated!");
        }

        static void DemonstrateChainOfResponsibility()
        {
            Console.WriteLine("\n=== Chain of Responsibility Pattern ===");
            var handler = new ChainOfResponsibility.RequestHandler();
            var request = new ChainOfResponsibility.Request { Description = "Test Request" };
            handler.ProcessRequest(request);
        }

        static void DemonstrateCommand()
        {
            Console.WriteLine("\n=== Command Pattern ===");
            var editor = new Command.TextEditor();
            var history = new Command.TextEditorHistory(editor);

            editor.Write("Hello ");
            history.Save();
            editor.Write("World!");
            history.Save();

            Console.WriteLine($"Current text: {editor.GetText()}");
            history.Undo();
            Console.WriteLine($"After undo: {editor.GetText()}");
        }

        static void DemonstrateInterpreter()
        {
            Console.WriteLine("\n=== Interpreter Pattern ===");
            var evaluator = new Interpreter.ExpressionEvaluator();
            evaluator.SetVariable("x", 5);
            evaluator.SetVariable("y", 10);
            int result = evaluator.Evaluate("x + y");
            Console.WriteLine($"Expression result: {result}");
        }

        static void DemonstrateIterator()
        {
            Console.WriteLine("\n=== Iterator Pattern ===");
            var collection = new Iterator.ConcreteAggregate<string>();
            collection.Add("Item 1");
            collection.Add("Item 2");
            collection.Add("Item 3");

            var manager = new Iterator.CollectionManager<string>(collection);
            manager.ProcessCollection();
        }

        static void DemonstrateMediator()
        {
            Console.WriteLine("\n=== Mediator Pattern ===");
            var chatRoom = new Mediator.ChatRoom();
            var user1 = new Mediator.User("Alice");
            var user2 = new Mediator.User("Bob");

            chatRoom.RegisterUser(user1);
            chatRoom.RegisterUser(user2);

            user1.SendMessage("Hello, Bob!");
            user2.SendMessage("Hi, Alice!");
        }

        static void DemonstrateMemento()
        {
            Console.WriteLine("\n=== Memento Pattern ===");
            var editor = new Memento.TextEditor();
            var history = new Memento.TextEditorHistory(editor);

            editor.Write("Hello ");
            history.Save();
            editor.Write("World!");
            history.Save();

            Console.WriteLine($"Current text: {editor.GetText()}");
            history.Undo();
            Console.WriteLine($"After undo: {editor.GetText()}");
        }

        static void DemonstrateObserver()
        {
            Console.WriteLine("\n=== Observer Pattern ===");
            var weatherStation = new Observer.WeatherStation();
            var display1 = new Observer.CurrentConditionsDisplay();
            var display2 = new Observer.ForecastDisplay();

            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            weatherStation.SetMeasurements(25.5f, 65.0f, 1013.25f);
            weatherStation.SetMeasurements(26.0f, 70.0f, 1012.50f);
        }

        static void DemonstrateState()
        {
            Console.WriteLine("\n=== State Pattern ===");
            var trafficLight = new State.TrafficLight();

            for (int i = 0; i < 3; i++)
            {
                trafficLight.Change();
                trafficLight.ShowCurrentState();
            }
        }

        static void DemonstrateStrategy()
        {
            Console.WriteLine("\n=== Strategy Pattern ===");
            var paymentProcessor = new Strategy.PaymentProcessor(new Strategy.CreditCardPayment());
            paymentProcessor.ProcessPayment(100.00);

            paymentProcessor.SetPaymentStrategy(new Strategy.PayPalPayment());
            paymentProcessor.ProcessPayment(50.00);

            paymentProcessor.SetPaymentStrategy(new Strategy.BankTransferPayment());
            paymentProcessor.ProcessPayment(200.00);
        }

        static void DemonstrateTemplateMethod()
        {
            Console.WriteLine("\n=== Template Method Pattern ===");
            ReportGenerator pdfReport = new TemplateMethod.PDFReportGenerator();
            pdfReport.GenerateReport();

            Console.WriteLine();

            ReportGenerator excelReport = new TemplateMethod.ExcelReportGenerator();
            excelReport.GenerateReport();
        }

        static void DemonstrateVisitor()
        {
            Console.WriteLine("\n=== Visitor Pattern ===");
            var documentProcessor = new Visitor.DocumentProcessor();
            documentProcessor.AddDocument(new Visitor.ConcreteComponentA());
            documentProcessor.AddDocument(new Visitor.ConcreteComponentB());

            documentProcessor.ProcessDocuments(new Visitor.ConcreteVisitor1());
            documentProcessor.ProcessDocuments(new Visitor.ConcreteVisitor2());
        }
    }
} 