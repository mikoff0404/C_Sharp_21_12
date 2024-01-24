

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numerat = a * b;
//     int denomerat = c + d;
//     double result = numerat / denomerat;
//     return result;
// }

// double result = CalculateFormula(6, 1, 3, 3);
// Console.Write(result);



// void Square(int n)
// {
//     int i = 1;
//     while(i <= n)
//     {
//         Console.Write($"{i*i} ");
//         i++;
//     }
// }
// Square(5);
// Square(10);
// Square(15); 


// void ZeroEvenElements(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }

//     }
// }

// int square(int value)
// {
//     int result = value * value;
//     return result;
// }
// void square1(int value1)
// {
//     int result1 = value1 + value1;
//     Console.Write(result1);
// }
// square1 (4);

// int number = square (5);
// Console.WriteLine($" {number}");

// double calculate(int a, int b, int c)
// {
//     double num1 = a * b;
//     double num2 = num1 / c;
//     return num2;
// }

// double num3 = calculate(2, 5, 5);
// Console.Write(num3);

// Console.WriteLine("Введите число - ");
// int a = int.Parse(Console.ReadLine()!);

// int square(int b)
// {
//     int result = b * b;
//     return result;
// }


// Console.Write($"квадрат числа {a} равен {square(a)}");

// Console.WriteLine("Введите число - ");
// int b = int.Parse(Console.ReadLine()!);

// void printsquare(int n)
// {
//     int i = 1;
//     while (i <= n)
//     {
//         Console.Write($"{i*i} "); 
//         i++;
//     }

// }

// printsquare(b);


// void ZeroEvenElements(int[] arr)
// {
//         for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }

// void PrintArr(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] arr = {1,2,3,4,5};
// ZeroEvenElements(arr);
// PrintArr(arr);

// Random rnd = new Random();

// int size = 100;
// int[] array = new int[size];
// int i = 0;
// while(i < size)
// {
//     array[i] = rnd.Next(-100, 100);
//     i++;
// }
// i=0;
// while(i < size)
// {
//     Console.Write($" {array[i] }");
//     i++;
// }

// int size = 5;
// int[] arr = new int[size];
// int i = 0;
// while(i<arr.Length)
// {
//     Console.Write($"введите {i}- элемент массива ");
//     arr[i] = int.Parse(Console.ReadLine()!);
//     i++;
// }
// i=0;
// while(i<arr.Length)
// {
//     Console.Write($"{arr[i]} ");
//     i++;
// }

Console.Write("Введите размер массива - "); // вводим размер массива
int size = int.Parse(Console.ReadLine()!); // 

int[] array1 = GenerateArray(size); // обращаемся к функции генерации массива
//получаем сгенерированный массив array1

int Result1 = CountNumbers(array1); //обращение к функции подсчета четных чисел

int[] GenerateArray(int size1) // функция генерации массива
{
    int[] array = new int[size1];
    Random rnd = new Random();
    for (int i = 0; i < size1; i++)
    {
        array[i] = rnd.Next(0, 99);
        Console.Write($"{array[i]} ");
        
    }
    return array; // возвращаем массив после реализованной генерации
}

int CountNumbers(int[] array001)
{
    int count = 0;
    foreach (int e in array001)
    {
        if(e % 10 == 1 && e % 7 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write($"result - {Result1}");