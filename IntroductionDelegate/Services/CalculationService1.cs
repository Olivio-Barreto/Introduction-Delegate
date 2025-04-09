namespace IntroductionDelegate.Services;

public class CalculationService1
{
    public static void ShowMax(double n1, double n2)
    {
        var result = n1 > n2 ? n1 : n2;
        Console.WriteLine(result);
    }

    public static void ShowSum(double n1, double n2)
    {
        var result = n1 + n2;
        Console.WriteLine(result);
    }
}
