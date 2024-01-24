
int[] array = ArrGenerate(10);

int result = CountSimpleNumber(array);
PrintArr(array);
 Console.WriteLine($"\nNumber of prime numbers: {result}");

int[] ArrGenerate(int size)
{
    Random rnd = new Random();
    int[] array = new int[size];    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

void PrintArr(int[] array1)
{
    foreach (int e in array1)
    {
        Console.Write($"{e} ");
    }
}

int CountSimpleNumber (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(FindSimpleNum(arr[i]))
        {
            count++;
        }
     
    }
    return count;
}

bool FindSimpleNum (int N)
{
    if(N < 2)
        return false;
    for (int i = 2; i < N; i++)
    {
        if (N % i == 0)
        {
            return false;
        }
        
    }
    return true;
}





