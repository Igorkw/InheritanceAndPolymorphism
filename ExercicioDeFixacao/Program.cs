using ExercicioDeFixacao.Entities;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write($"How many procuts? ");
int nProducts = int.Parse(Console.ReadLine());

for (int i = 1; i <= nProducts; i++)
{
    Console.Write($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    string cui = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = int.Parse(Console.ReadLine());

    switch (cui)
    {
        case "u":
            Console.Write("Manufacture date (YYYY/MM/dd): ");
            DateTime date = DateTime.Parse((Console.ReadLine()));

            products.Add(new UsedProduct(name, price, date));
            break;
        case "i":
            Console.Write("Customs fee: ");
            double customsFee = int.Parse(Console.ReadLine());

            products.Add(new ImportedProduct(name, price, customsFee));
            break;
        default:
            products.Add(new Product(name, price));
            break;
    }
}
Console.WriteLine("\nPrice tag:");
foreach(Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
