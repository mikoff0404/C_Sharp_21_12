Console.Write("Enter number - ");
int a1 = Convert.ToInt32(Console.ReadLine()!);

int a2 = a1 * (-1);
while (a2 <= a1)
{
    Console.Write(a2 + " ");
    a2 = a2 + 1;
}