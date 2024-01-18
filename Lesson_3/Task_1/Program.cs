

double CalculateFormula(int a, int b, int c, int d)
{
    double numerat = a * b;
    int denomerat = c + d;
    double result = numerat / denomerat;
    return result;
}

double result = CalculateFormula(6, 1, 3, 3);
Console.Write(result);