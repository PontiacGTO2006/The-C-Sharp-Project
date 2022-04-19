// This program will define the properties of a bear Harvey, then quiz the user on the properties.
Bear b = new Bear("6 feet 3 inches");
Age a = new Age("61");
Car c = new Car("2021 Rustler Trident Race GT");

Console.WriteLine("Harvey knowledge check: See if you can answer all of the questions below correctly.");
Console.WriteLine("How old is Harvey?");
if(Console.ReadLine() == "61")
{
    Console.WriteLine("Correct.");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine("Next question: What car does Harvey drive?");
if (Console.ReadLine() == "61")
{
    Console.WriteLine("Correct.");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine("Final question: how tall is Harvey?");
if (Console.ReadLine() == "6 feet 3 inches")
{
    Console.WriteLine("Correct.");
}
else
{
    Console.WriteLine("Incorrect.");
}

public class Bear
{
    string Height;
    public Bear (string n)
    {
        Height = n;
        Console.WriteLine("We will now present to you the height of the bear Harvey: " + n);
    }
}

public class Age
{
    int Hrvage;
    public Age (string a)
    {
        Hrvage = 61;
        Console.WriteLine("We will now present to you the age of the bear Harvey: " + a);
    }
}

public class Car
{
    string Hrvcar;
    public Car (string c)
    {
        Hrvcar = c;
        Console.WriteLine("We will now present to you the car the bear Harvey drives: " + c);
    }
}

public class KnowledgeCheck
{
    
}


