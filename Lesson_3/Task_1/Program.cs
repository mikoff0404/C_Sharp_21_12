

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numerat = a * b;
//     int denomerat = c + d;
//     double result = numerat / denomerat;
//     return result;
// }

// double result = CalculateFormula(6, 1, 3, 3);
// Console.Write(result);

void Square(int n)
{
    int i = 1;
    while(i <= n)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}
Square(5);
Square(10);
Square(15);