//Напишите программу, которая принимает
//на вход целое число из отрезка [10, 99] и показывает
//наибольшую цифру числа.

Console.WriteLine("Введите двухзначное число - ");
int a = int.Parse(Console.ReadLine()!);

if (a < 10 && a > 99)
{
    Console.WriteLine("Введено не двухзначное");
}
else
{
    int a1 = a / 10;
    int a2 = a % 10;
    if (a1 > a2)
    {
        Console.WriteLine(a1);
    }
    else
    {
        Console.WriteLine(a2);
    }
}

