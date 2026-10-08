using Assigment_5_OOP_Simulation.Part2_HotelReservationSystem.src;

namespace Part2_HotelReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
