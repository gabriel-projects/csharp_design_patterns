namespace DesignPatternsV1.Creational.Builder
{
    public interface IProduct
    {
        void AddPart(string part);
        string ListParts();
    }
} 