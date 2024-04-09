

Console.WriteLine("Enter opertor (+/-)");
char userOperator =char.Parse(Console.ReadLine());
Console.WriteLine("Siseste esimene nr");
int firstNumb = Int32.Parse(Console.ReadLine());
Console.WriteLine("Siseste teine nr");
int secondNumb = Int32.Parse(Console.ReadLine());

switch (userOperator)
{

    case '+' :
        Sum(secondNumb, firstNumb);
        break;

    default:
        Console.WriteLine("vale");
        break;
}




static void Sum(int a, int b)
    {
    Console.WriteLine($"{a} + {b} = {a+b}");
}

