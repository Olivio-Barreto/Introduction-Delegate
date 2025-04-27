using Func.Entities;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new()
        {
            new Product("Tv", 3200.00),
            new Product("Mouse", 50.00),
            new Product("Macbook", 5600.00)
        };

        List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }
}
