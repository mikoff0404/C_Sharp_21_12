
Console.Write("Введите размер массива - "); // вводим размер массива
int size = int.Parse(Console.ReadLine()!); // 

int[] array1 = GenerateArray(size); // обращаемся к функции генерации массива
//получаем сгенерированный массив array1

int Evenresult = CountEvenNumbers(array1); //обращение к функции подсчета четных чисел

int[] GenerateArray(int size1) // функция генерации массива
{
    int[] array = new int[size1];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write($"{array[i]} ");
        
    }
    return array; // возвращаем массив после реализованной генерации
}

int CountEvenNumbers(int[] arraylocal) // функция подсчета четных чисел
{
    int count = 0;
    foreach (int e in arraylocal)
    {
        if(e % 2 == 0)
        count++;
    }
    return count; // на выходе число четных чисел
}

Console.Write($"количество четных чисел в массиве - {Evenresult}"); 
// вывод результата на консоль