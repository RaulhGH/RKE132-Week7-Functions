Console.WriteLine("coming or leaving? (in/out)");


string userChoice = Console.ReadLine();

if (userChoice=="in")
{
    PrintHello();
}

else
{
    PrintBy();
}





static void PrintHello()
{
    Console.WriteLine("Hello!");
}

static void PrintBy()
{
    Console.WriteLine("By!");
}