
int[] array = { 2, 3, 1, 7, 5, 6, 3};
int n = array.Length - 1;
if (array.Length % 2 == 0)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        array[i] = array[i] * array[n];
        n = n - 1;
        Console.Write(array[i] + " ");
    }
}
else
{
    for (int i = 0; i < (array.Length-1) / 2; i++)
    {
    array[i] = array[i] * array[n];
        n = n - 1;
        Console.Write(array[i] + " ");
    }
Console.Write("  элемент " + array[(array.Length-1)/2] + " не имеет пары");
}

