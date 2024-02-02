namespace hw1;

public class Person
{
    string _name;
    public Person(string name)
    {
        _name=name;
    }
    public virtual void ToString()
    {
        System.Console.WriteLine("Person");
    }
}
