namespace Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;

internal class Product
{

    public int Id { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }
    public int Stock { get; private set; }

    //adding new product 
    public Product(int id, string name, double price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ReduceStock(int newStock)
    {
        Stock -= newStock;
    }
    //print product details
    override public string ToString()
    {
        return $"id :{Id}   name: {Name}   price: {Price}   stock={Stock}";
    }


}
