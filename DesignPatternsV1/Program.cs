using System;
using DesignPatternsV1.Creational.Singleton;
using DesignPatternsV1.Creational.FactoryMethod;
using DesignPatternsV1.Creational.AbstractFactory;
using DesignPatternsV1.Creational.Builder;
using DesignPatternsV1.Creational.Prototype;
using DesignPatternsV1.Structural.Adapter;
using DesignPatternsV1.Structural.Bridge;
using DesignPatternsV1.Structural.Composite;
using DesignPatternsV1.Structural.Decorator;
using DesignPatternsV1.Structural.Facade;
using DesignPatternsV1.Structural.Flyweight;
using DesignPatternsV1.Structural.Proxy;
using DesignPatternsV1.Behavioral.ChainOfResponsibility;
using DesignPatternsV1.Behavioral.Command;
using DesignPatternsV1.Behavioral.Iterator;
using DesignPatternsV1.Behavioral.Mediator;
using DesignPatternsV1.Behavioral.Memento;
using DesignPatternsV1.Behavioral.Observer;
using DesignPatternsV1.Behavioral.State;
using DesignPatternsV1.Behavioral.Strategy;
using DesignPatternsV1.Behavioral.TemplateMethod;
using DesignPatternsV1.Behavioral.Visitor;

namespace DesignPatternsV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Design Patterns Demo ===");
            Console.WriteLine("Running all pattern demonstrations...\n");

            // Creational Patterns
            Console.WriteLine("\n=== Creational Patterns ===");
            DemonstrateSingleton();
            DemonstrateFactoryMethod();
            DemonstrateAbstractFactory();
            DemonstrateBuilder();
            DemonstratePrototype();

            // Structural Patterns
            Console.WriteLine("\n=== Structural Patterns ===");
            DemonstrateAdapter();
            DemonstrateBridge();
            DemonstrateComposite();
            DemonstrateDecorator();
            DemonstrateFacade();
            DemonstrateFlyweight();
            DemonstrateProxy();

            // Behavioral Patterns
            Console.WriteLine("\n=== Behavioral Patterns ===");
            DemonstrateChainOfResponsibility();
            DemonstrateCommand();
            DemonstrateIterator();
            DemonstrateMediator();
            DemonstrateMemento();
            DemonstrateObserver();
            DemonstrateState();
            DemonstrateStrategy();
            DemonstrateTemplateMethod();
            DemonstrateVisitor();

            Console.WriteLine("\nAll demonstrations completed!");
            Console.ReadKey();
        }

        private static void DemonstrateSingleton()
        {
            Console.WriteLine("\n1. Singleton Pattern:");
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            Console.WriteLine($"Are both instances the same? {singleton1 == singleton2}");
            singleton1.SomeBusinessLogic();
        }

        private static void DemonstrateFactoryMethod()
        {
            Console.WriteLine("\n2. Factory Method Pattern:");
            Creator creator = new ConcreteCreator();
            Console.WriteLine(creator.SomeOperation());
        }

        private static void DemonstrateAbstractFactory()
        {
            Console.WriteLine("\n3. Abstract Factory Pattern:");
            IAbstractFactory factory = new ConcreteFactory1();
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

        private static void DemonstrateBuilder()
        {
            Console.WriteLine("\n4. Builder Pattern:");
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartB();
            Console.WriteLine(builder.GetProduct().ListParts());
        }

        private static void DemonstratePrototype()
        {
            Console.WriteLine("\n5. Prototype Pattern:");
            var p1 = new Person
            {
                Age = 42,
                BirthDate = Convert.ToDateTime("1977-01-01"),
                Name = "Jack Daniels",
                IdInfo = new IdInfo(666)
            };

            var p2 = (Person)p1.Clone();
            Console.WriteLine($"Original: {p1.Name}, {p1.Age}, {p1.BirthDate}, ID: {p1.IdInfo.IdNumber}");
            Console.WriteLine($"Clone: {p2.Name}, {p2.Age}, {p2.BirthDate}, ID: {p2.IdInfo.IdNumber}");

            p2.Name = "John Smith";
            p2.IdInfo.IdNumber = 999;
            Console.WriteLine("\nAfter modifying clone:");
            Console.WriteLine($"Original: {p1.Name}, {p1.Age}, {p1.BirthDate}, ID: {p1.IdInfo.IdNumber}");
            Console.WriteLine($"Clone: {p2.Name}, {p2.Age}, {p2.BirthDate}, ID: {p2.IdInfo.IdNumber}");
        }

        private static void DemonstrateAdapter()
        {
            Console.WriteLine("\n1. Adapter Pattern:");
            // Add your Adapter demonstration here
        }

        private static void DemonstrateBridge()
        {
            Console.WriteLine("\n2. Bridge Pattern:");
            // Add your Bridge demonstration here
        }

        private static void DemonstrateComposite()
        {
            Console.WriteLine("\n3. Composite Pattern:");
            // Add your Composite demonstration here
        }

        private static void DemonstrateDecorator()
        {
            Console.WriteLine("\n4. Decorator Pattern:");
            // Add your Decorator demonstration here
        }

        private static void DemonstrateFacade()
        {
            Console.WriteLine("\n5. Facade Pattern:");
            // Add your Facade demonstration here
        }

        private static void DemonstrateFlyweight()
        {
            Console.WriteLine("\n6. Flyweight Pattern:");
            // Add your Flyweight demonstration here
        }

        private static void DemonstrateProxy()
        {
            Console.WriteLine("\n7. Proxy Pattern:");
            // Add your Proxy demonstration here
        }

        private static void DemonstrateChainOfResponsibility()
        {
            Console.WriteLine("\n1. Chain of Responsibility Pattern:");
            // Add your Chain of Responsibility demonstration here
        }

        private static void DemonstrateCommand()
        {
            Console.WriteLine("\n2. Command Pattern:");
            // Add your Command demonstration here
        }

        private static void DemonstrateIterator()
        {
            Console.WriteLine("\n3. Iterator Pattern:");
            // Add your Iterator demonstration here
        }

        private static void DemonstrateMediator()
        {
            Console.WriteLine("\n4. Mediator Pattern:");
            // Add your Mediator demonstration here
        }

        private static void DemonstrateMemento()
        {
            Console.WriteLine("\n5. Memento Pattern:");
            // Add your Memento demonstration here
        }

        private static void DemonstrateObserver()
        {
            Console.WriteLine("\n6. Observer Pattern:");
            // Add your Observer demonstration here
        }

        private static void DemonstrateState()
        {
            Console.WriteLine("\n7. State Pattern:");
            // Add your State demonstration here
        }

        private static void DemonstrateStrategy()
        {
            Console.WriteLine("\n8. Strategy Pattern:");
            // Add your Strategy demonstration here
        }

        private static void DemonstrateTemplateMethod()
        {
            Console.WriteLine("\n9. Template Method Pattern:");
            // Add your Template Method demonstration here
        }

        private static void DemonstrateVisitor()
        {
            Console.WriteLine("\n10. Visitor Pattern:");
            // Add your Visitor demonstration here
        }
    }
}
