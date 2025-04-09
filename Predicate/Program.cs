using Predicate.Entites;

namespace Predicate;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900));
        list.Add(new Product("Mouse", 50));
        list.Add(new Product("Tablet", 350.50M));
        list.Add(new Product("HD case", 80.90M));

        list.RemoveAll(ProductTest);

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    private static bool ProductTest(Product product)
    {
        return product.Price > 100;
    }
}
