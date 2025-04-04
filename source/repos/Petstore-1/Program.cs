// Program.cs
using System.Text.Json;
using Store;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Project1
{
    class Program
    {
        static IProductLogic productLogic = new ProductLogic();

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to view a dog leash");
            Console.WriteLine("Press 3 to view in stock products only");
            Console.WriteLine("Press 4 to view total price of inventory");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    AddProduct();
                }
                else if (userInput == "2")
                {
                    ViewDogLeash();
                }
                else if (userInput == "3")
                {
                    ViewInStockProducts();
                }
                else if (userInput == "4")
                {
                    ViewTotalPriceOfInventory();
                }

                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Press 2 to view a dog leash");
                Console.WriteLine("Press 3 to view in stock products only");
                Console.WriteLine("Press 4 to view total price of inventory");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Select product type: 1 for CatFood, 2 for DogLeash");
            string productType = Console.ReadLine();

            if (productType == "1")
            {
                CatFood catFood = new CatFood();

                Console.Write("Enter name: ");
                catFood.Name = Console.ReadLine();

                Console.Write("Enter price: ");
                catFood.Price = decimal.Parse(Console.ReadLine());

                Console.Write("Enter quantity: ");
                catFood.Quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter description: ");
                catFood.Description = Console.ReadLine();

                Console.Write("Enter weight in pounds: ");
                catFood.WeightPounds = double.Parse(Console.ReadLine());

                Console.Write("Is it kitten food? (true/false): ");
                catFood.KittenFood = bool.Parse(Console.ReadLine());

                productLogic.AddProduct(catFood);

                Console.WriteLine("Product added: ");
                Console.WriteLine(JsonSerializer.Serialize(catFood));
            }
            else if (productType == "2")
            {
                DogLeash dogLeash = new DogLeash();

                Console.Write("Enter name: ");
                dogLeash.Name = Console.ReadLine();

                Console.Write("Enter price: ");
                dogLeash.Price = decimal.Parse(Console.ReadLine());

                Console.Write("Enter quantity: ");
                dogLeash.Quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter description: ");
                dogLeash.Description = Console.ReadLine();

                Console.Write("Enter length in inches: ");
                dogLeash.LengthInches = int.Parse(Console.ReadLine());

                Console.Write("Enter material: ");
                dogLeash.Material = Console.ReadLine();

                productLogic.AddProduct(dogLeash);

                Console.WriteLine("Product added: ");
                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
            }
            else
            {
                Console.WriteLine("Invalid product type.");
            }
        }

        static void ViewDogLeash()
        {
            Console.Write("Enter the name of the dog leash: ");
            string name = Console.ReadLine();
            DogLeash dogLeash = productLogic.GetDogLeashByName(name);

            if (dogLeash != null)
            {
                Console.WriteLine("Dog Leash found: ");
                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
            }
            else
            {
                Console.WriteLine("Dog Leash not found.");
            }
        }

        static void ViewInStockProducts()
        {
            var inStockProducts = productLogic.GetOnlyInStockProducts();

            Console.WriteLine("In-stock products: ");
            inStockProducts.ForEach(productName => Console.WriteLine(productName));
        }

        static void ViewTotalPriceOfInventory()
        {
            var totalPrice = productLogic.GetTotalPriceOfInventory();

            Console.WriteLine($"Total price of inventory: ${totalPrice}");
        }
    }
}


public class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catFoods;

        public ProductLogic()
        {
            _products = new List<Product>
            {
                new CatFood { Name = "Whiskas", Price = 12.99m, Quantity = 10, Description = "Dry Cat Food", WeightPounds = 2.5, KittenFood = false },
                new DogLeash { Name = "Nylon Leash", Price = 15.99m, Quantity = 0, Description = "Strong dog leash", LengthInches = 48, Material = "Nylon" },
                new CatFood { Name = "Kitten Delight", Price = 8.99m, Quantity = 5, Description = "Canned Cat Food", WeightPounds = 1.2, KittenFood = true }
            };

            _dogLeashes = new Dictionary<string, DogLeash>();
            _catFoods = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash dogLeash)
            {
                _dogLeashes[dogLeash.Name] = dogLeash;
            }
            else if (product is CatFood catFood)
            {
                _catFoods[catFood.Name] = catFood;
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _products.InStock().Select(x => x.Name).ToList();
        }

        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(x => x.Price * x.Quantity).Sum();
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeashes[name];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }

