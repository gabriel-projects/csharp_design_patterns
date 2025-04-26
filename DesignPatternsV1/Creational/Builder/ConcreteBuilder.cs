namespace DesignPatternsV1.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private ConcreteProduct _product = new ConcreteProduct();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new ConcreteProduct();
        }

        public void BuildPartA()
        {
            _product.AddPart("PartA");
        }

        public void BuildPartB()
        {
            _product.AddPart("PartB");
        }

        public void BuildPartC()
        {
            _product.AddPart("PartC");
        }

        public ConcreteProduct GetProduct()
        {
            var result = _product;
            Reset();
            return result;
        }
    }
} 