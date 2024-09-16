using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Entities;
using Curso.Entities;


List<Product> products = new List<Product>();

Console.WriteLine("Enter the numer of products: ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    Console.WriteLine($"Product {i + 1} data: ");
    Console.WriteLine("Common, used or imported? (c/u/i)");
    string typeOfProduct = Console.ReadLine();

    if (typeOfProduct == "c")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());

        Product product = new Product(name, price);

        products.Add(product);
    }

    if (typeOfProduct == "u")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

        UsedProduct product = new UsedProduct(name, price, manufactureDate);

        products.Add(product);
    }

    if (typeOfProduct == "i")
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Customs Fee: ");
        double customsFee = double.Parse(Console.ReadLine());

        ImportedProduct product = new ImportedProduct(name, price, customsFee); git

        products.Add(product);
    }
}

Console.WriteLine("PRICE TAGS:");

foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}

