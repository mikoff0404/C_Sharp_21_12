
// Console.Write("ввдите число");


while (true)
{
    Console.Write("введите число сумма цифр которого четная или символ / q / - ");
    string word = Console.ReadLine()!;

    if(word == "q")
    {
        Console.Write("stop because /q/");
        return;
    }
    else
    {
        int number = int.Parse(word);
        if (NumbersSum(number) % 2 == 0)
        {
            Console.Write("stop because even sum");
            return;
        }

    }

}

int NumbersSum(int m)
{
    int count = 0;
    while(m > 0)
    {
    count = m % 10 + count;
    m = m / 10;
    }
    return count;
}
