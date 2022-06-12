Console.WriteLine("Welcome to the Rustler Technologies Inc. Login Wizard. This is where you create and then login to your Rustler account. Use this tool if you are new to Rustler and want to create a new systems account. You will enter your desired password, username, security questions, and then login to your account using that information. Let's begin.");

// Section 1
Console.WriteLine("Please type your desired password below. It must be at least 20 characers long and include at least 1 special character and number.");
var inpupassword1 = Console.ReadLine();

Console.WriteLine("Please type your desired username below. It must be at least 15 characters long and include no numbers or special characters.");
var inpuuserna1 = Console.ReadLine();

Console.WriteLine("Please type security question number one: your current job position at Rustler. It must be accurate.");
var inpujobpos1 = Console.ReadLine();

Console.WriteLine("Please type security question number two: one of your current vehicles' make and model. It must be accurate.");
var inpuvehicar1 = Console.ReadLine();

// Section 2: The Login
Console.Clear();
Console.WriteLine("Congratulations. You have successfully completed the creation of your Rustler account. Now, let's login to that account.");
Console.WriteLine("Please type your Rustler account password below.");
var inpupassword2 = Console.ReadLine();
if (inpupassword1 == inpupassword2)
{
    Console.WriteLine("Your password is correct.");
}
else
{
    Console.WriteLine("Your password is incorrect. Try again.");
    if (Console.ReadLine() == inpupassword1)
    {
        Console.WriteLine("Your password is now correct.");
    }
    else
    {
        Console.WriteLine("That's still incorrect. You've reached the maximum number of chances for entering your passcode. You are booted out.");
        Environment.Exit(12);
    }
}
Console.WriteLine("Please type your current job position at Rustler below.");
var inpujobpos2 = Console.ReadLine();
if (inpujobpos2 == inpujobpos1)
{
    Console.WriteLine("Your job position is correct.");
}
else
{
    Console.WriteLine("Your job position is incorrect. Try again.");
    if (Console.ReadLine() == inpujobpos1)
    {
        Console.WriteLine("Your job position is now correct.");
    }
    else
    {
        Console.WriteLine("That's still incorrect. You've reached the maximum number of chances for entering your job position. You are booted out.");
        Environment.Exit(12);
    }
}
Console.WriteLine("Please type your current username for your Rustler account below.");
var inpuuserna2 = Console.ReadLine();
if (inpuuserna2 == inpuuserna1)
{
    Console.WriteLine("That is correct.");
}
else
{
    Console.WriteLine("Your username is incorrect. Try again.");
    if (Console.ReadLine() == inpuuserna1)
    {
        Console.WriteLine("That is now correct.");
    }
    else
    {
        Console.WriteLine("That's still <b>STILL</b> incorrect. You've reached the maximum number of chances for entering your username. You are booted out.");
        Environment.Exit(12);
    }
}
Console.WriteLine("Please type your current vehicle model.");
var inpuvehicar2 = Console.ReadLine();
if (inpuvehicar2 == inpuvehicar1)
{
    Console.WriteLine("That is correct.");
}
else
{
    Console.WriteLine("That is incorrect.");
    if (Console.ReadLine() == inpuvehicar1)
    {
        Console.WriteLine("That is now correct.");
    }
    else
    {
        Console.WriteLine("That's still incorrect. You've reached the maximum number of chances for entering your current vehicle model. You are booted out.");
        Environment.Exit(12);
    }
}
Console.WriteLine("If you are seeing this text now, it means you have correctly confirmed your login to your new Rustler account. Thanks for participating in the Rustler Login Wizard, " + inpuuserna1 + "!");