using System;
using System.Collections.Generic;




namespace CashRegister
{
    class Program
    {
        static List<Product> products = new List<Product>();
        static double totalPrice = 0; // need initial to add products (starts from 0)


          static void Main(string[] args)
        {
            // OF initialize - got error no static main
            InitializeProducts();
            MainMenu();
        }




        static void InitializeProducts()
        {
         
            products.Add(new Product("apple", 5, 0.5));
            products.Add(new Product("banana", 10, 0.3));
            products.Add(new Product("kiwi", 7, 0.8));
            products.Add(new Product("orange", 5, 0.6));
            products.Add(new Product("pear", 8, 0.7));
        }




        static void MainMenu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. Exit");




            int selection = int.Parse(Console.ReadLine());




            switch (selection)
            {
                case 1:
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Product Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    AddProduct(name, quantity);
                    break;
                case 2:
                    DisplayProductsMenu();
                    break;
                case 3:
                    Checkout();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }




        static void DisplayProductsMenu() // shows products and allows return to main menu (loop)
        {
            while (true)
            {
                Console.Clear(); // OF - clears display for better transition (UX)




                Console.WriteLine("*****************************");
                Console.WriteLine("Product Display");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Currently available");
                Console.WriteLine("2. Back to Main Menu");




                int selection = int.Parse(Console.ReadLine()); // input based on selection




                switch (selection) // product list or mm - switches based on choice
                {
                    case 1:
                        Product.ProductList(products);
                        break;
                    case 2:
                        MainMenu();
                        return;
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }




        static void AddProduct(string name, int quantity)
        {
           
            Product product = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));




            if (product != null) // check for valid name
            {
                if (quantity <= product.Quantity)
                {
                    // update quantity
                    product.Quantity -= quantity;


                    double productPrice = product.Price * quantity;
                    totalPrice += productPrice;




                    Console.WriteLine($"{quantity} {name}(s) added. Current Total: {product.Quantity}");
                    Console.WriteLine($"Total Price: ${totalPrice:F2}"); // two decimal spaces
                }
                else
                {
                    Console.WriteLine("Not enough products available.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }




            MainMenu();
        }




        static void Checkout()
        {
           
            Console.WriteLine("Select a payment method:");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Credit Card");
            Console.WriteLine("3. Check");




            int paymentSelection = int.Parse(Console.ReadLine());




            switch (paymentSelection)
            {
                case 1:
                   
                    HandleCashPayment();
                    break;
                case 2:
                   
                    HandleCreditCardPayment();
                    break;
                case 3:
                   
                    HandleCheckPayment();
                    break;
                default:
                    Console.WriteLine("Invalid payment method selection.");
                    break;
            }
            Console.WriteLine("Checkout completed.");
            Console.WriteLine("--------------------");




            double pdvAmount = totalPrice * 0.25;
            double finalTotal = totalPrice + pdvAmount;




            Console.WriteLine($"Total Price: ${totalPrice:F2}");
            Console.WriteLine($"Total Price after PDV: ${finalTotal:F2}");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Thank you for your purchase!");
            Console.WriteLine("-----------------------");
        }




        static void HandleCashPayment()
        {
           
            Console.WriteLine("Cash payment selected. Please proceed with cash payment.");
        }




        static void HandleCreditCardPayment()
        {
           
            Console.WriteLine("Credit card payment selected. Please proceed with credit card payment.");
        }




        static void HandleCheckPayment()
        {
           
            Console.WriteLine("Check payment selected. Please proceed with check payment.");
        }
       
    }




    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }




        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }




        public static void ProductList(List<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.Quantity > 0)
                {
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Quantity: {product.Quantity}");
                    Console.WriteLine($"Price: ${product.Price:F2}");
                }
            }
            Console.WriteLine("********************************************");
        }
    }
}
