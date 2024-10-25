Console.Write("Введите верхний(a) лимит>>");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите нижний(b) лимит>>");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите количество разбиений на прямоугольники>>");
int n = Convert.ToInt32(Console.ReadLine());

string path = "C:\\Users\\prdb\\Desktop\\someProject123\\answer.txt";
double h = (b - a)/n;
double result = 0;

double fun(double x) 
{
    return 2*Math.Pow(x, 2) + 3*x;
}

for (double i = 1; i <= n; i++) 
{
    double sigma = a + (i * h) / 2;
    result += fun(sigma);
}
result *= h;

Console.WriteLine($"Ответ был записан в {path}");
using (StreamWriter writer = new StreamWriter(path, false)) 
{
    await writer.WriteLineAsync(Convert.ToString(result));
}