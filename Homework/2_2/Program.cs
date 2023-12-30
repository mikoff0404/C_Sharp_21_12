//Напишите программу, которая принимает
//на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
//0 и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.

Console.WriteLine("Enter X - ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y - ");
int y = int.Parse(Console.ReadLine()!);

if (x == 0 || y == 0)
{
    Console.WriteLine("Недопустимые значения: X или Y = 0");
}
else
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("номер координатной плоскости - 1");
    }
    else
    {
        if (x < 0 && y > 0)
        {
            Console.WriteLine("номер координатной плоскости - 2");
        }
        else
        {
            if (x < 0 && y < 0)
            {
                Console.WriteLine("номер координатной плоскости - 3");
            }
            else
            {
                Console.WriteLine("номер координатной плоскости - 4");
            }
        }
    }
}