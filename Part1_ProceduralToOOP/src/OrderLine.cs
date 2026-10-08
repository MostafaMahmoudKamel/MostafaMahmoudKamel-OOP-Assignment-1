using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;

internal class OrderLine
{
   
    public Product Product { get; private set; }

    public int Quantity { get; private set; }

    public OrderLine(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public double CalculateLineTotal()
    {
        return Product.Price * Quantity;
    }

    override public string ToString()
    {
        return $"Product: {Product.Name}, Quantity: {Quantity}, Line Total: {CalculateLineTotal()}";
    }
}
