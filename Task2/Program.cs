double Clir(string text)
{
    Console.Write(text);
    text = Console.ReadLine();
    double result = double.Parse(text);
    return result;
}

void GetNeededSum (double a, double b, double sum)
{
if (a > b) 
{
    Console.WriteLine($"Sum of numbers in thus interval {sum} ");
   return;
}
sum = sum + (a++);
GetNeededSum(a, b, sum);

}

double a = Clir("Enter where the array starts ");
double b = Clir("Enter where the array ends ");
GetNeededSum(a,b,0);
