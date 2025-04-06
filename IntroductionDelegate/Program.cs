using IntroductionDelegate.Services;

namespace IntroductionDelegate;

internal delegate double BinaryNumericOperation(double n1, double n2);

public class Program
{
    static void Main(string[] agrs)
    {
        double a = 10;
        double b = 12;


        BinaryNumericOperation operation = CalculationService.Sum;

        var result = operation(a, b);

        Console.WriteLine(result);
    }
}
