double Clir(string text)
{
    Console.Write(text);
    text = Console.ReadLine();
    double result = double.Parse(text);
    return result;
}

void GetNeededNumbers (double a, double b)
{
if (a > b) 
{
   return;
}
GetNeededNumbers(a, b-1);
if (b%2==0)
Console.WriteLine(b);

}

double a = Clir("Enter where the array starts ");
double b = Clir("Enter where the array ends ");
GetNeededNumbers(a,b);
