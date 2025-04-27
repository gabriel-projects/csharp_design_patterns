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
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine(target.GetRequest());
        }

        private static void DemonstrateBridge()
        {
            Console.WriteLine("\n2. Bridge Pattern:");
            IImplementation implementation = new ConcreteImplementationA();
            Abstraction abstraction = new Abstraction(implementation);
            Console.WriteLine(abstraction.Operation());

            Console.WriteLine("\nExtended abstraction:");
            abstraction = new ExtendedAbstraction(implementation);
            Console.WriteLine(abstraction.Operation());
        }

        private static void DemonstrateComposite()
        {
            Console.WriteLine("\n3. Composite Pattern:");
            Structural.Composite.IComponent leaf = new Leaf();
            Console.WriteLine($"Leaf: {leaf.Operation()}");

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine($"Tree: {tree.Operation()}");
        }

        private static void DemonstrateDecorator()
        {
            Console.WriteLine("\n4. Decorator Pattern:");
            DesignPatternsV1.Structural.Decorator.IComponent simple = new ConcreteComponent();
            Console.WriteLine($"Simple component: {simple.Operation()}");

            DesignPatternsV1.Structural.Decorator.IComponent decorator1 = new ConcreteDecoratorA(simple);
            DesignPatternsV1.Structural.Decorator.IComponent decorator2 = new ConcreteDecoratorB(decorator1);
            Console.WriteLine($"Decorated component: {decorator2.Operation()}");
        }

        private static void DemonstrateFacade()
        {
            Console.WriteLine("\n5. Facade Pattern:");
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Console.WriteLine(facade.Operation());
        }

        private static void DemonstrateFlyweight()
        {
            Console.WriteLine("\n6. Flyweight Pattern:");
            var factory = new FlyweightFactory(new string[] { "Chevrolet", "Mercedes Benz", "BMW" });
            factory.ListFlyweights();

            var flyweight1 = factory.GetFlyweight("Chevrolet");
            var flyweight2 = factory.GetFlyweight("BMW");
            var flyweight3 = factory.GetFlyweight("BMW");

            flyweight1.Operation("Camaro");
            flyweight2.Operation("M5");
            flyweight3.Operation("X6");

            factory.ListFlyweights();
        }

        private static void DemonstrateProxy()
        {
            Console.WriteLine("\n7. Proxy Pattern:");
            RealSubject realSubject = new RealSubject();
            Proxy proxy = new Proxy(realSubject);
            proxy.Request();
        }

        private static void DemonstrateChainOfResponsibility()
        {
            Console.WriteLine("\n1. Chain of Responsibility Pattern:");
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            ClientCode(monkey);
        }

        private static void ClientCode(IHandler handler)
        {
            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");
                var result = handler.Handle(food);
                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }

        private static void DemonstrateCommand()
        {
            Console.WriteLine("\n2. Command Pattern:");
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
            invoker.DoSomethingImportant();
        }

        private static void DemonstrateIterator()
        {
            Console.WriteLine("\n3. Iterator Pattern:");
            var aggregate = new ConcreteAggregate();
            aggregate.Add("Item 1");
            aggregate.Add("Item 2");
            aggregate.Add("Item 3");

            var iterator = aggregate.CreateIterator();
            Console.WriteLine("Iterating over collection:");
            Console.WriteLine(iterator.Current());
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current());
            }
        }

        private static void DemonstrateMediator()
        {
            Console.WriteLine("\n4. Mediator Pattern:");
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine("\nClient triggers operation D.");
            component2.DoD();
        }

        private static void DemonstrateMemento()
        {
            Console.WriteLine("\n5. Memento Pattern:");
            Originator originator = new Originator("Super-duper-super-puper-super.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\nClient: Once more!\n");
            caretaker.Undo();
        }

        private static void DemonstrateObserver()
        {
            Console.WriteLine("\n6. Observer Pattern:");
            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2");
            ConcreteObserver observer3 = new ConcreteObserver("Observer 3");

            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.Attach(observer3);

            Console.WriteLine("Setting state to 'First State'");
            subject.State = "First State";

            Console.WriteLine("\nDetaching Observer 2");
            subject.Detach(observer2);

            Console.WriteLine("\nSetting state to 'Second State'");
            subject.State = "Second State";
        }

        private static void DemonstrateState()
        {
            Console.WriteLine("\n7. State Pattern:");
            DesignPatternsV1.Behavioral.State.Context context = new DesignPatternsV1.Behavioral.State.Context(new ConcreteStateA());

            // The context will automatically transition between states
            // as each state's Handle method is called
            context.TransitionTo(new ConcreteStateA());
        }

        private static void DemonstrateStrategy()
        {
            Console.WriteLine("\n8. Strategy Pattern:");
            var context = new DesignPatternsV1.Behavioral.Strategy.Context(new ConcreteStrategyA());
            var data = new List<string> { "a", "b", "c", "d", "e" };

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            var result = context.ExecuteStrategy(data);
            Console.WriteLine(string.Join(", ", (List<string>)result));

            Console.WriteLine("\nClient: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            result = context.ExecuteStrategy(data);
            Console.WriteLine(string.Join(", ", (List<string>)result));
        }

        private static void DemonstrateTemplateMethod()
        {
            Console.WriteLine("\n9. Template Method Pattern:");
            Console.WriteLine("Same client code can work with different subclasses:");

            Console.WriteLine("\nClient: Testing ConcreteClass1...");
            AbstractClass concreteClass1 = new ConcreteClass1();
            concreteClass1.TemplateMethod();

            Console.WriteLine("\nClient: Testing ConcreteClass2...");
            AbstractClass concreteClass2 = new ConcreteClass2();
            concreteClass2.TemplateMethod();
        }

        private static void DemonstrateVisitor()
        {
            Console.WriteLine("\n10. Visitor Pattern:");
            List<DesignPatternsV1.Behavioral.Visitor.IComponent> components = new List<DesignPatternsV1.Behavioral.Visitor.IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            ClientCode(components, visitor1);

            Console.WriteLine("\nIt allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            ClientCode(components, visitor2);
        }

        private static void ClientCode(List<DesignPatternsV1.Behavioral.Visitor.IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
