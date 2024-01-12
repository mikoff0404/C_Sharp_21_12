
int n = 5;
int[] array = { 31, 4, 3, 7, 9 };
int i = 0;
int max_weight = array[0];

while (i < n)
{
    if (array[i] > max_weight)
    {
        max_weight = array[i];
    }
    i = i + 1;
}
Console.WriteLine($"Max weight = {max_weight}");