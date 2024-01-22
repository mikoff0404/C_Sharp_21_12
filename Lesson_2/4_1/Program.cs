


Random rnd = new Random();
void ArrGenerate(size);
{
    int[] array = new int[size];    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 101);
    }
}

int size = 100;
ArrGenerate(size);
