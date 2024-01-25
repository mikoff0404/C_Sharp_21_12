Console.Write("Введите размер массива - "); // вводим размер массива
int size = int.Parse(Console.ReadLine()!); // 

int[] array1 = GenerateArray(size); // обращаемся к функции генерации массива
//получаем сгенерированный массив array1

int[] GenerateArray(int size1) // функция генерации массива
{
    int[] array = new int[size1];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.Next(1, 10);
        Console.Write($"{array[i]} ");
        
    }
    Console.WriteLine(); // перевод строки
    return array; // возвращаем массив после реализованной генерации
    
}

int[] ResultArray = ReverseArray(array1); //обращаемся к функции переворачивания массива
PrintResult(ResultArray); //обращение к функции вывода массива на консоль 

int[] ReverseArray(int[] arr) // функция разворота массива
{
    int newLength = arr.Length;
    
    for (int i = 0; i < newLength / 2; i++)
    {
        int t = arr[i];
        arr[i] = arr[newLength - i - 1];
        arr[newLength - i - 1] = t;
    }
    return arr;
}

void PrintResult(int[] array2) //функция вывода массива на консоль
{
    foreach (int e in array2)
    {
        Console.Write($"{e} ");
    }
}