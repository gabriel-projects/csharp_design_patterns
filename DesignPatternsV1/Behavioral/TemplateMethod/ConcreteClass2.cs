namespace DesignPatternsV1.Behavioral.TemplateMethod
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            System.Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            System.Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1()
        {
            System.Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
        }
    }
} 