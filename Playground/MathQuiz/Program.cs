Console.WriteLine("Welcome to the square-roots- and exponents-level Math Quiz. Are you ready to take the test? You will have five seconds to close this console window.");
Thread.Sleep(5000);

Console.WriteLine("First question.");
Console.WriteLine("What is the square root of 81?");
   if (Console.ReadLine() == "9")
   {
        int a = 20;
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
        int b = 40;
   }
   else
   {
        Console.WriteLine("Incorrect.");
   }

Console.WriteLine("What is the square root of 49 times 3^3?");
   if (Console.ReadLine() == "189")
   {
        Console.WriteLine("Correct.");
        int c = 60;
   }
   else
   {
        Console.WriteLine("Incorrect.");
   }

Console.WriteLine("What is 4^5 times 2^8?");
   if (Console.ReadLine() == "262144")
   {
        Console.WriteLine("Correct.");
        int d = 80;
   }
   else
   {
        Console.WriteLine("Incorrect.");
   }

Console.WriteLine("Final question: what is 3^4 times 4^3?");
{
   if (Console.ReadLine() == "5184")
   {
        Console.WriteLine("Correct.");
        int e = 100;
   }
   else
   {
        Console.WriteLine("Incorrect.");
   }
}
Console.WriteLine("Thank you for completing this math quiz. Your score is"); // Figure out how to print the score using the 5 variables a, b, c, d, and e above.