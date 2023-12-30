
//Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число - ");
int a = int.Parse(Console.ReadLine()!);
string word = "";

while (a != 0)
{
    if (word != "")
    {
        word = "," + word;
    }
word = a % 10 + word;
a = a / 10;
}
Console.WriteLine(word);
