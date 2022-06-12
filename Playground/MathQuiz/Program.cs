Console.WriteLine("Welcome to the Rustler Technologies Inc. Login Validator. This is where you login to your Rustler account. You will go through a series of checks to make sure you are really a Rustler employee. Let's begin.");
Console.WriteLine("Please type your Rustler account password below.");
var inpupassword1 = Console.ReadLine();
var uspassword1 = "37CVN5H39V82NB039B83NVGH3";
if (inpupassword1 == uspassword1)
{
    Console.WriteLine("Your password is correct.");
}
else
{
    Console.WriteLine("Your password is incorrect. Try again.");
    if (Console.ReadLine() == uspassword1)
    {
        Console.WriteLine("Your password is now correct.");
    }
    else
    {
        Console.WriteLine("That's still incorrect. You've reached the maximum number of chances for entering your passcode. You are booted out.");
        Environment.Exit(1);
    }
}
Console.WriteLine("Please type your Rustler account corporate username below.");
var inpupuserna1 = Console.ReadLine();
var ususerna1 = "HarveyAndersonSignoffPortal";
if (inpupuserna1 == ususerna1)
{
    Console.WriteLine("Your username is correct.");
}
else
{
    Console.WriteLine("Your username is incorrect. Try again.");
    if (Console.ReadLine() == ususerna1)
    {
        Console.WriteLine("Your username is now correct.");
    }
    else
    {
        Console.WriteLine("That's still incorrect. You've reached the maximum number of chances for entering your passcode. You are booted out.");
        Environment.Exit(1);
    }
}
Console.WriteLine("Please type your current job position at Rustler below.");
var inpujobpos1 = Console.ReadLine();
var usjobpos1 = "Project Manager A-6";