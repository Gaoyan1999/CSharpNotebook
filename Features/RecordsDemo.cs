namespace CSharpNotebook.Features;

public static class RecordsDemo
{
    public static void Run()
    {
        var person1 = new Person("Daniel", 25);
        // cannot do that
        // person1.Age = 12;
        var person2 = person1 with { Age = 26 };
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }

    public record Person(string Name, int Age);
}