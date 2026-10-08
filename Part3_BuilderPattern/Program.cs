using Assigment_5_OOP_Simulation.Part3_BuilderPattern.src;

namespace Part3_BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3  Why Are 20-Parameter Constructors a Problem? (Builder pattern)
            Invoice i = new InvoiceBuilder(

                invoiceId: 1,
                customerName: "Mostafa",
                customerEmail: "mostafaKamel2002921@gmail.com").Build();

            Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Address");
        }
    }
}
