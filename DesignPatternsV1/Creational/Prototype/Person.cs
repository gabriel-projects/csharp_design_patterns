namespace DesignPatternsV1.Creational.Prototype
{
    public class Person : IPrototype
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;

        public Person()
        {
        }

        public Person(Person person)
        {
            Age = person.Age;
            BirthDate = person.BirthDate;
            Name = person.Name;
            IdInfo = new IdInfo(person.IdInfo.IdNumber);
        }

        public IPrototype Clone()
        {
            return new Person(this);
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }
} 