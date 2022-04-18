// This code will define the properties of a bear Harvey and then spit out those values when the user asks for them in the console.
Bear b = new Bear("Harvey");
Age a = new Age("61");
Car c = new Car("2021 Rustler Trident Race GT");

public class Bear
{
    string Harvey;
    public Bear (string n)
    {
        Harvey = n;
        Console.WriteLine("We will now present to you the name of the Bear: " + n);
    }
}

public class Age
{
    readonly int Hrvage;
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