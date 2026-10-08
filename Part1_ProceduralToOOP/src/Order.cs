using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;

//order contain list<items>orderline
internal class Order
{

    public int Id { get; private set; }

    public DateTime Date { get; private set; }

    public bool IsPaid { get; private set; }

    public Customer Customer { get; private set; }

    public List<OrderLine> Lines { get; private set; }


    public Order(DateTime orderDate, int id, DateTime date, bool isPaid, Customer customer, OrderLine orderLine)
    {
        Id = id;
        Date = date;
        IsPaid = isPaid;
        Customer = customer;
        Lines = new List<OrderLine> { orderLine };
        //خلي بالك ضيفنا ده علشان
        //reduce stock لما نضيف orderline جديد
        if (orderLine != null)
        {
            AddLineToOrder(orderLine); // Add the order line to the order
        }
      
    }



   public void AddLineToOrder(OrderLine orderLine)
    {
        if (IsPaid)
        {
            Console.WriteLine("ERROR: cannot change a paid order.\n");
            return;
        }
        if (orderLine.Quantity <= 0)
        {
            Console.WriteLine("ERROR: quantity must be positive.\n");
            return;
        }
        if (orderLine.Product.Stock < orderLine.Quantity)
        {
            Console.WriteLine($"ERROR: not enough stock for product # {orderLine.Product.Id} .\n");
            return;
        }

        Lines.Add(orderLine);
        orderLine.Product.ReduceStock(orderLine.Quantity); // Reduce stock


    }



   public  double CalculateOrderTotal()
    {
        /*
         * note: ClR doesn't assign values to local variables, so we must initialize it 
         * - clr intialize global variables to default values, but not local variables
         */

        Double total = 0.0;
        for (int i = 0; i < Lines.Count; i++)
        {
            total += Lines[i].CalculateLineTotal();
        }

        // vip customer discount: 10% 
        if (Customer != null && Customer.IsVip)
        {
            total *= 0.90;
        }

        return total;
    }

    //public Order getOrderById()
    public void MarkOrderPaid()
    {
        // 1. Check if the order is already paid
        if (IsPaid)
        {
            Console.WriteLine($"Order #{Id} is already marked as paid.\n");
            return;
        }
        if (Lines == null || Lines.Count == 0)
        {
            Console.WriteLine("ERROR: Cannot pay for an empty order.\n");
            return;
        }
        IsPaid = true;
        Console.WriteLine($"Order #{Id} has been successfully marked as paid.\n");
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Order ID: {Id}, Date: {Date}, Is Paid: {IsPaid}");
        sb.AppendLine($"Customer: {Customer.Name} (ID: {Customer.Id})");
        sb.AppendLine("Order Lines:");
        foreach (var line in Lines)
        {
            sb.AppendLine(line.ToString());
        }
        sb.AppendLine($"Total Order Amount: {CalculateOrderTotal()}");
        return sb.ToString();
    }




}
//}