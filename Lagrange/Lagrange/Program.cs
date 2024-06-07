// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double[] xValues = { 0, 1, 2 };
double[] yValues = { 1, 2, 4 };

double x = 1.5;

double result = interpolation(xValues, yValues, x);

Console.WriteLine(result.ToString());

static double interpolation(double[] x, double[] y, double xToEvaluate)
{
    int n = x.Length;
    double result = 0.0;

    for(int i = 0; i < n; i++)
    {
        double term = y[i];
        for(int j = 0; j < n; j++)
        {
            if(j != i)
            {
                term *= (xToEvaluate - x[j]) / (x[i] - x[j]);
                Console.WriteLine(term);
            }
        }
        result += term;
    }

    return result;
}