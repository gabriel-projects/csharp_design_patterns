namespace DesignPatternsV1.Behavioral.TemplateMethod
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            System.Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            System.Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }
} 