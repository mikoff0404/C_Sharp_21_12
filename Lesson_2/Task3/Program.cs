
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

max_weight = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max_weight)
    {
        max_weight = array[j];
    }
}
Console.WriteLine($"Max weight = {max_weight}");

max_weight = array[0];
foreach(int e in array)
{
    if (e > max_weight)
    {
        max_weight = e;
    }
}
Console.WriteLine($"Max weight = {max_weight}");