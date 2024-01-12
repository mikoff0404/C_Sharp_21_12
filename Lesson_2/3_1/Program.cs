//напишите программу , которая
//определяет присутствует ли данное  число в массиве


int [] array = {1, 3, 4, 19, 3};
Console.WriteLine("Enter number - ");
int a = int.Parse(Console.ReadLine()!);
int flag = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a)
    {
        flag = 1;
    }
}
if (flag > 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
               
    







    

