using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Products
{
    public class Products
    {
        public static void Main()
        {
            if (!File.Exists("../../Output.txt"))
            {
                File.Create("../../Output.txt").Close();
            }
            
            Dictionary<string, Dictionary<string, Product>> products = new Dictionary<string, Dictionary<string, Product>>();

            string[] stockedProductsFromFile = File.ReadAllLines("../../Output.txt");

            for (int i = 0; i < stockedProductsFromFile.Length; i++)
            {
                string[] productParams = stockedProductsFromFile[i].Split(' ');

                string type = productParams[0];
                string name = productParams[1];
                decimal price = decimal.Parse(productParams[2]);
                int quantity = int.Parse(productParams[3]);

                if (!products.ContainsKey(type))
                {
                    products[type] = new Dictionary<string, Product>();
                }
                if (!products[type].ContainsKey(name))
                {
                    products[type][name] = new Product()
                    {
                        Name = name,
                        Type = type,
                        Price = price,
                        Quantity = quantity
                    };
                }
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(' ');

                if (inputParams.Length == 4)
                {
                    string name = inputParams[0];
                    string type = inputParams[1];
                    decimal price = decimal.Parse(inputParams[2]);
                    int quantity = int.Parse(inputParams[3]);

                    if (!products.ContainsKey(type))
                    {
                        products[type] = new Dictionary<string, Product>();

                        if (!products[type].ContainsKey(name))
                        {
                            products[type][name] = new Product();
                        }

                        products[type][name].Name = name;
                        products[type][name].Type = type;
                        products[type][name].Price = price;
                        products[type][name].Quantity = quantity;
                    }

                    if (products[type].ContainsKey(name))
                    {
                        products[type][name].Price = price;
                        products[type][name].Quantity = quantity;
                    }
                    else
                    {
                        products[type][name] = new Product
                        {
                            Name = name,
                            Type = type,
                            Price = price,
                            Quantity = quantity
                        };
                    }
                }

                else if (inputParams[0] == "stock")
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var type in products)
                    {
                        foreach (var product in type.Value)
                        {
                            sb.AppendLine($"{product.Value.Type} {product.Value.Name} {product.Value.Price} {product.Value.Quantity}");
                        }
                    }

                    File.WriteAllText("../../Output.txt", sb.ToString());
                }

                else if (inputParams[0] == "analyze")
                {
                    string[] stockedProductsInput = File.ReadAllLines("../../Output.txt");

                    List<Product> stockedProducts = new List<Product>();

                    if (stockedProductsInput.Any())
                    {
                        for (int i = 0; i < stockedProductsInput.Length; i++)
                        {
                            string[] productsParams = stockedProductsInput[i].Split(' ');

                            stockedProducts.Add(new Product
                            {
                                Type = productsParams[0],
                                Name = productsParams[1],
                                Price = decimal.Parse(productsParams[2]),
                                Quantity = int.Parse(productsParams[3])
                            });
                        }

                        stockedProducts = stockedProducts.OrderBy(x => x.Type).ToList();

                        foreach (var product in stockedProducts)
                        {
                            Console.WriteLine($"{product.Type}, Product: {product.Name}");
                            Console.WriteLine($"Price: ${product.Price}, Amount Left: {product.Quantity}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No products stocked");
                    }
                }

                else if (inputParams[0] == "sales")
                {
                    Dictionary<string, decimal> typeIncome = new Dictionary<string, decimal>();

                    foreach (var type in products)
                    {
                        decimal income = 0;

                        foreach (var product in type.Value)
                        {
                            income += product.Value.Price * product.Value.Quantity;
                        }

                        typeIncome[type.Key] = income;
                    }

                    typeIncome = typeIncome.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                    foreach (var type in typeIncome)
                    {
                        if (type.Value != 0)
                        {
                            Console.WriteLine($"{type.Key}: ${type.Value:F2}");
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
