using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;

internal class OrderSystem
{
    private List<Customer> _customers = new List<Customer>();
    private List<Product> _products = new List<Product>();

    private List<Order> _orders = new List<Order>();

    public void AddCustomer(Customer customer)
    {
        if (GetCustomerById(customer.Id) != null)
        {
            Console.WriteLine($"Customer with ID {customer.Id} already exists.");
        }
        _customers.Add(customer);
    }

    public void AddProduct(Product product)
    {
        if (GetProductById(product.Id) != null)
        {
            Console.WriteLine($"Product with ID {product.Id} already exists.");
        }
        _products.Add(product);
    }

    public void AddOrder(Order order)
    {
        if (_orders.Exists(o => o.Id == order.Id))
        {
            Console.WriteLine($"Order with ID {order.Id} already exists.");
            return;
        }
        _orders.Add(order);
    }

    public Customer GetCustomerById(int id)
    {
        return _customers.Find(c => c.Id == id);
    }

    public Product GetProductById(int id) => _products.Find(p => p.Id == id);
    public Order GetOrderById(int id) => _orders.Find(o => o.Id == id);

    public void PrintCustomers()
    {
        Console.WriteLine($"\n === CUSTOMERS ({_customers.Count}) ===");
        foreach (var c in _customers)
            Console.WriteLine(c);
    }

    public void PrintProducts()
    {
        Console.WriteLine($"\n === PRODUCTS ({_products.Count}) ===\n");
        foreach (var p in _products)
            Console.WriteLine(p);
    }

    public void PrintAllOrders()
    {
        Console.WriteLine($"=== ALL ORDERS ({_orders.Count}) ====");
        foreach (var o in _orders)
            Console.WriteLine(o);
    }

    public double TotalSalesPaidOnly()
    {
        double sum = 0.0;
        foreach (var o in _orders)
        {
            if (o.IsPaid)
                sum += o.CalculateOrderTotal();
        }
        return sum;
    }

    public void SeedSampleData()
    {
        AddCustomer(new Customer(1, "Mona Ali", "mona@example.com", "Cairo", true));
        AddCustomer(new Customer(2, "Omar Hassan", "omar@example.com", "Alexandria", false));
        AddCustomer(new Customer(3, "Sara Nabil", "sara@example.com", "Giza", false));

        AddProduct(new Product(101, "USB Cable", 50.0, 100));
        AddProduct(new Product(102, "Wireless Mouse", 250.0, 40));
        AddProduct(new Product(103, "Mechanical Keyboard", 1200.0, 15));
        AddProduct(new Product(104, "Laptop Stand", 400.0, 25));
    }

    public void RunInteractiveMenu()
    {
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("\n---------- MENU ----------");
            Console.WriteLine("1) Print customers");
            Console.WriteLine("2) Print products");
            Console.WriteLine("3) Print all orders");
            Console.WriteLine("4) Print one order by id");
            Console.WriteLine("5) Create order");
            Console.WriteLine("6) Add line to order");
            Console.WriteLine("7) Mark order paid");
            Console.WriteLine("8) Show paid sales total");
            Console.WriteLine("0) Exit");
            Console.Write("Choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) continue;

            if (choice == 1) PrintCustomers();
            else if (choice == 2) PrintProducts();
            else if (choice == 3) PrintAllOrders();
            else if (choice == 4)
            {
                Console.Write("Order id: ");
                int id = int.TryParse(Console.ReadLine(), out int parsedId) ? parsedId : 0;
                Order o = GetOrderById(id);
                if (o != null) Console.WriteLine(o);
                else Console.WriteLine($"ERROR: order id {id} not found.\n");
            }
            else if (choice == 5)
            {
                Customer customer1 = new Customer(1, "Mostafa Kamel", "mostafaKamel@gmail.com", city: "Mansoura", false);
                Product keyboard = new Product(101011, "keyboard", 110, 5);
                Order order1 = new Order( DateTime.Now, 1,DateTime.Now.AddDays(3),false, customer1, new OrderLine(keyboard, 3));
                _orders.Add(order1);
            }
            else if (choice == 7)
            {
                Console.Write("Order id: ");
                int id = int.TryParse(Console.ReadLine(), out int parsedId) ? parsedId : 0;
                Order o = GetOrderById(id);
                if (o != null) o.MarkOrderPaid();
                else Console.WriteLine($"ERROR: order id {id} not found.\n");
            }
            else if (choice == 8)
            {
                Console.WriteLine($"Paid sales total {TotalSalesPaidOnly():F2}");
            }
            else if (choice == 0)
            {
                Console.WriteLine("Bye");
            }
        }
    }


}