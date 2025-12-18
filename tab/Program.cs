//Табулирование функций 14 вариант Высокий уровень
try
{
    double x = 1;
    double k = 1;
    double y = 1;
    double h = 0.1;
    do
    {
        for (double t = 2 * k; t > 0; t--)
        {
            y = t * y;
        }
        double f = (Math.Pow(x, 2 * k)) / y;
        Console.WriteLine($"f({x}) = {f}");
        x += h;
        k++;
    }
    while (x < 2.1);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}