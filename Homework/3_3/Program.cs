
// Задайте массив из вещественных чисел с
//  ненулевой дробной частью. 
//  Найдите разницу между максимальным и 
//  минимальным элементов массива.

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double difference = 0;
int i = 0;
double min_num = array[0];
double max_num = array[0];
while (i < array.Length)
{
    if (array[i] > max_num)
    {
        max_num = array[i];
    }
    if (array[i] < min_num)
    {
        min_num = array[i];
    }
i++;
}
difference = max_num - min_num;
Console.Write(difference);