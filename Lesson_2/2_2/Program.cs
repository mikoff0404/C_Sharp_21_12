
Console.WriteLine("Enter number - ");
int a = int.Parse(Console.ReadLine()!);

int num1 = (a / 10) % 10;
int num2 = a % 10;
double result = Math.Pow(num1, num2);

Console.WriteLine(result);






