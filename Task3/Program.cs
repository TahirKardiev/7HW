double Clir(string text)
{
    Console.Write(text);
    text = Console.ReadLine();
    double result = double.Parse(text);
    return result;
}

double GetAckerman(double a, double b)
{
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return GetAckerman(a - 1, 1);
    if (a > 0 && b > 0) return GetAckerman(a - 1, GetAckerman(a, b - 1));
return GetAckerman(a, b);
}
double a = Clir("Enter where the array starts ");
double b = Clir("Enter where the array ends ");
Console.WriteLine($"Ackermans function ({a},{b}) = {GetAckerman(a, b)}");