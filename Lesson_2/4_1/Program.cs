


Random rnd = new Random();
void ArrGenerate(int size);
{
    int[] array = new int[size];    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
}

void PrintArr(int[] array1)
{
    foreach (int e in array1)
    {
        Console.Write($"{e} ");
    }
}


ArrGenerate(100);
PrintArr(array);

