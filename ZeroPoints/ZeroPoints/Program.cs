// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(newton("4x^3-5X^2+3x+5", 10, 5));

static double bisection(string f, double a, double b, int n)
{
    double x0 = 0.1, m;

    switch(f)
    {
        case "2sinx*cos":
            {
                if ((2*Math.Sin(a) * Math.Cos(a) * (2*Math.Sin(b) * Math.Cos(b))) < 0)
                {
                    for(int i = 0; i < n;  i++)
                    {
                        m = (a + b) / 2;
                        if ((2 * Math.Sin(a) * Math.Cos(a) * (2 * Math.Sin(m) * Math.Cos(m))) < 0)
                        {
                            m = (a + m) / 2;
                        } 
                        else
                        {
                            m = (m + b) / 2;
                        }
                        x0 = m;
                    }
                }
                break;
            }
        case "5x^5*4x^4*2x-10":
            {
                if ((5*Math.Pow(a, 5)-2*Math.Pow(a, 4)+2*a - 10) * (5 * Math.Pow(b, 5) - 2 * Math.Pow(b, 4) + 2 * b - 10) < 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        m = (a + b) / 2;
                        if ((5 * Math.Pow(a, 5) - 2 * Math.Pow(a, 4) + 2 * a - 10) * (5 * Math.Pow(m, 5) - 2 * Math.Pow(m, 4) + 2 * m - 10) < 0)
                        {
                            m = (a + m) / 2;
                        }
                        else
                        {
                            m = (m + b) / 2;
                        }
                        x0 = m;
                    }
                }
                break;
            }
        case "sin":
            {
                if ((Math.Sin(a) * Math.Cos(b)) < 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        m = (a + b) / 2;
                        if ((Math.Sin(a) * Math.Cos(m)) < 0)
                        {
                            m = (a + m) / 2;
                        }
                        else
                        {
                            m = (m + b) / 2;
                        }
                        x0 = m;
                    }
                }
                break;
            }
        default: { return 0.0; }
    }
    return x0;
}

static double newton(string f, double a, int n)
{
    double x0 = a;

    switch (f)
    {
        case "5x^5*4x^4*2x-10":
            {
                for(int i = 0; i < n; i++)
                {
                    x0 = x0 - (5 * Math.Pow(x0, 5) - 2 * Math.Pow(x0, 4) + 2 * x0 - 10) / (25 * Math.Pow(x0, 4) - 8 * Math.Pow(x0, 3) + 2);
                }
                break;
            }
        case "4x^3-5X^2+3x+5":
            {
                for(int i = 0; i < n; i++)
                {
                    x0 = x0 - (4 * Math.Pow(x0, 3) - 5 * Math.Pow(x0, 2) + 3 * x0 + 5) / (12 * Math.Pow(x0, 2) - 10 * x0 + 3);
                }
                break;
            }
        default: return 0;
    }

    return x0;
}