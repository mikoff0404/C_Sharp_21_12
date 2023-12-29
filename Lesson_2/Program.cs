//напишите программу, которая принимает на вход
// трехзанчное число и удаляет вторую цифру этого числа

Console.Write("Enter number - ");
int a = int.Parse(Console.ReadLine()!);

int b = a / 100 * 10 + a % 10;
Console.Write(b);

