// See https://aka.ms/new-console-template for more information
using LinqDemo.DataSource;
using LinqDemo.Helper;

Console.WriteLine("Hello, This is an example of linq filtering app.");
Console.WriteLine("\n");

var numbers = Number.GetNumbers(50);

Console.WriteLine("Here's the filtered result for even numbers: ");
var evenNumbers = numbers.Where(x => x % 2 == 0);
Display.Print(evenNumbers.ToList());
Console.WriteLine("\n");

Console.WriteLine("Here's the filtered result for odd numbers: ");
var oddNumbers = numbers.Where(x => x % 2 != 0);
Display.Print(oddNumbers.ToList());
Console.WriteLine("\n");

var allProducts = ProductsBuilder.GetProducts();

Console.WriteLine("Here's the filtered result for product items: ");
var filteredProducts = allProducts.Where(x => x.Price > 400);
Display.PrintProducts(filteredProducts.ToList());
Console.WriteLine("\n");