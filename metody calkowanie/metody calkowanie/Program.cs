// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
int n1 = 10, n2 = 100, n3 = 1000;
double a = 0, b = Math.PI;
Console.WriteLine("Calkowanie analityczne");
Console.WriteLine("Calka oznaczona z f(x) = sin={0} gdzie a={1}, b={2}", -Math.Cos(b) + Math.Cos(a), a, b);
Console.WriteLine("Calka metoda kwadratow {0}", integral("sin", a, b, n1));
Console.WriteLine("Calka metoda kwadratow {0}", integral("sin", a, b, n2));
Console.WriteLine("Calka metoda kwadratow {0}", integral("cos", a, b, n3));

Console.WriteLine("Calka metoda trapezow {0}", integral2("sin", a, b, n1));
Console.WriteLine("Calka metoda trapezow {0}", integral2("sin", a, b, n2));
Console.WriteLine("Calka metoda trapezow {0}", integral2("cos", a, b, n3));

static double integral(string f, double a, double b, int n)
{
    double value = 0;
    double dx = (b - a) / n;
    double x0 = a + dx / 2;
    
    switch (f)
    {
        case "sin":
            for (int i = 0; i < n; i++)
            {
                value += Math.Sin(x0 + i * dx)*dx;
            } 
            break;
        case "cos":
            for (int i = 0; i < n; i++)
            {
                value += Math.Cos(x0 + i * dx)*dx;
            }
            break;
        case "tg": 
            if((a>-Math.PI/2)&&(b>-Math.PI/2))
            for (int i = 0; i < n; i++)
            {
                value += Math.Tan(x0 + i * dx)*dx;
            }
            break;
        case "sqrt":
            for (int i = 0; i <= n; i++)
            {
                value += Math.Sqrt(x0 + i * dx)*dx;
            }
            break;
        default:
            value = Double.NaN;
            break;
    }
    return value;
}

static double integral2(string f, double a, double b, int n)
{
    double value = 0;
    double dx = (b - a) / n;
    double x0 = a;
    
    switch (f)
    {
        case "sin":
            for (int i = 0; i < n; i++)
            {
                value += ((Math.Sin(x0 + i * dx) + Math.Sin(x0 + ( i + 1 ) * dx)) * dx / 2);
            }
            break;
        case "cos":
            for (int i = 0; i < n; i++)
            {
                value += ((Math.Cos(x0 + i * dx) + Math.Cos(x0 + (i + 1) * dx)) * dx / 2);
            }
            break;
        case "tg":
            if ((a > -Math.PI / 2) && (b > -Math.PI / 2))
                for (int i = 0; i < n; i++)
                {
                    value += ((Math.Tan(x0 + i * dx) + Math.Tan(x0 + (i + 1) * dx)) * dx / 2);
                }
            break;
        case "sqrt":
            for (int i = 0; i <= n; i++)
            {
                value += ((Math.Sqrt(x0 + i * dx) + Math.Sqrt(x0 + (i + 1) * dx)) * dx / 2);
            }
            break;
        default:
            value = Double.NaN;
            break;
    }
    return value;
}