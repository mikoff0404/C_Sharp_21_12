
Console.WriteLine("Enter number 1 - ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter number 2 - ");
int b = int.Parse(Console.ReadLine()!);

if (a % b == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет, " + a % b);
}
