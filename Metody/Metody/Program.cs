// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
Console.WriteLine("pochodna analityczna");
Console.WriteLine("(sin{0}' = cos{0}={1})", 30, Math.Cos(30 * Math.PI / 180));

double h1 = 0.1, h2 = 0.01, h3 = 0.001;

Console.WriteLine("Pochodna obliczona numerycznie wzor I");
Console.WriteLine("sin({0}) = {1}, h={2}", 30, derivativePatern1("sin", 30 * Math.PI / 180, h1), h1);
Console.WriteLine("sin({0}) = {1}, h={2}", 30, derivativePatern1("sin", 30 * Math.PI / 180, h2), h2);
Console.WriteLine("sin({0}) = {1}, h={2}", 30, derivativePatern1("sin", 30 * Math.PI / 180, h3), h3);

Console.WriteLine("Pochodna obliczona numerycznie wzor II");
Console.WriteLine("sin({0}) = {1}, h={2}", 30, derivativePatern2("sin", 30 * Math.PI / 180, h1), h1);
Console.WriteLine("sin({0}) = {1}, h={2}", 30, derivativePatern2("sin", 30 * Math.PI / 180, h2), h2);
Console.WriteLine("sin({0}) = {1}, h={2}", 30, derivativePatern2("sin", 30 * Math.PI / 180, h3), h3);



static double derivativePatern1(string f, double x0, double h)
{
    double value;

    switch(f)
    {
        case "sin": value = (Math.Sin(x0 + h) - Math.Sin(x0)) / h;
            break;
        case "cos": value = (Math.Cos(x0 + h) - Math.Cos(x0)) / h;
            break;
        case "tg": value = (Math.Tan(x0 + h) - Math.Tan(x0)) / h;
            break;
        case "sqrt": value = (Math.Sqrt(x0 + h) - Math.Sqrt(x0)) / h;
            break;
        default: value = Double.NaN;
            break;
    }    

    return value;
}

//TODO: II Wzor

static double derivativePatern2(string f, double x0, double h)
{
    double value;

    switch (f)
    {
        case "sin":
            value = (Math.Sin(x0 + h) - Math.Sin(x0 - h)) / (2*h);
            break;
        case "cos":
            value = (Math.Cos(x0 + h) - Math.Cos(x0 - h)) / (2*h);
            break;
        case "tg":
            value = (Math.Tan(x0 + h) - Math.Tan(x0 - h)) / (2*h);
            break;
        case "sqrt":
            value = (Math.Sqrt(x0 + h) - Math.Sqrt(x0 - h)) / (2*h);
            break;
        default:
            value = Double.NaN;
            break;
    }

    return value;
}