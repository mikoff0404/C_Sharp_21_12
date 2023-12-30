
Console.WriteLine("Enter number - ");
int a = int.Parse(Console.ReadLine()!);

if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(a / 100 % 10);
}