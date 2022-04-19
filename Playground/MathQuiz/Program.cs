Console.WriteLine("Welcome to the square-roots- and exponents-level Math Quiz. Are you ready to take the test? You will have five seconds to close this console window.");
Thread.Sleep(5000);
int i = 0;
while (i < 15)
{
    i += 10;
    Console.WriteLine("First question.");
    Console.WriteLine("What is the square root of 81?");
    if (Console.ReadLine() == "9")
    {
        Console.WriteLine("Correct.");
    }

    else
    {
        Console.WriteLine("Incorrect.");

    }

    Console.WriteLine("What is 4 to the sixth power?");
    if (Console.ReadLine() == "4096")
    {
        Console.WriteLine("Correct.");
    }

    else
    {
        Console.WriteLine("Incorrect.");
    }
    continue;
}
Console.WriteLine(i);