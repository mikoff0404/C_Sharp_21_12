
// Console.Write("Enter number - ");
// int n = int.Parse(Console.ReadLine()!);

// int[] arr = new int[n];
// int i = 0;

// while (i < arr.Length)
// {
//     arr[i] = i + 1;
//     Console.Write(arr[i]);
//     Console.Write(' ');
//     Console.Write($"{arr[i]} ");

//     i = i + 1;
// }

int n = 5;
int[] arr = {5, 6, 8, 6, 10};
int i = 0;

while (i < n)
{
    if (arr[i]% 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}
