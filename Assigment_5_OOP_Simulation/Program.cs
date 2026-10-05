using Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;
using Assigment_5_OOP_Simulation.Part2_HotelReservationSystem.src;
using Assigment_5_OOP_Simulation.Part3_BuilderPattern.src;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Order System!");

        OrderSystem orderSystem = new OrderSystem();
        orderSystem.SeedSampleData();
        orderSystem.RunInteractiveMenu();

        Customer c = new Customer(12, "mostafa", "mk@gamil.com", "Mansoura", true);
        Console.WriteLine(c);

        //Product keyBoard = new Product(1, "Keyboard", 100, 10);//price:100
        //Product mouse = new Product(2, "Mouse", 50, 20);//price:50

        //OrderLine ol1 = new OrderLine(keyBoard, 2);//quantity:2
        //Console.WriteLine(ol1.CalculateLineTotal());

        //OrderLine ol2 = new OrderLine(mouse, 3);//quantity:3
        //Console.WriteLine(ol2.CalculateLineTotal());

        //Order o = new Order(1, DateTime.Now, false, c, ol1);//quantity:2
        //o.AddLineToOrder(ol2);

        //Console.WriteLine($"Order total: {o.CalculateOrderTotal()}");
        //Console.WriteLine(o);
        //Console.WriteLine();
        //Console.WriteLine("After reducing stock:");
        //Console.WriteLine(keyBoard);

        //Console.WriteLine(mouse);

        //Order o2 = new Order(2, DateTime.Now, false, c, new OrderLine(mouse, 5));
        //Console.WriteLine($"Second Order total: {o2.CalculateOrderTotal()}");



        Console.WriteLine("============================================================================================");
        //02 Hotel Reservation System — Design From Requirements
        Guest Mostafa = new Guest(guestId: 1, fullName: "Mostafa", phoneNumber: "01002372929");
        Console.WriteLine(Mostafa);

        Room firstRoom = new Room(101, roomType: RoomType.Single, intialRoomRate: 0);

        Mostafa.MakeReservation(
            new Reservation(
                1,
            checkInDate: DateTime.Now,
            checkOutDate: DateTime.Now.AddDays(3),
            room: firstRoom
            ));


        //3  Why Are 20-Parameter Constructors a Problem? (Builder pattern)
        Invoice i = new InvoiceBuilder(

            invoiceId: 1,
            customerName: "Mostafa",
            customerEmail : "mostafaKamel2002921@gmail.com").Build();

        Console.WriteLine(i);
        Console.WriteLine();
        Console.WriteLine("Address");
        




    }
}