using ActionTraining.Entities;

namespace ActionTraining;

internal class Program
{
    static void Main()
    {
        List<Product> list = new List<Product>()
        {
            new Product("TV", 900.0),
            new Product("Mouse", 50.0),
            new Product("Tablet", 350.0),
            new Product("HD case", 80.90)
        };

        Action<Product> action = p => { p.Price += p.Price * 0.1; };

        list.ForEach(action);

        foreach (var product in list)
        {
            Console.WriteLine(product);
        }
    }
}
