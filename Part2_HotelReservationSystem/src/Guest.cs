using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part2_HotelReservationSystem.src;

internal class Guest
{

    public int GuestId { get; init; }
    public string FullName { get; init; }
    public string PhoneNumber { get; init; }

    private readonly List<Reservation> _reservations = new List<Reservation>();
    public IReadOnlyList<Reservation> Reservations => _reservations.AsReadOnly();
    public Guest(int guestId, string fullName, string phoneNumber)
    {
        if(string.IsNullOrWhiteSpace(fullName)|| string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException("Full name cannot be empty.", nameof(fullName));
        }
        GuestId = guestId;
        FullName = fullName;
        PhoneNumber = phoneNumber;
    }

    public void MakeReservation(Reservation reservation)
    {
        //if (reservation.Room.IsUnderMaintenance)
        //{
        //    throw new InvalidOperationException("Cannot create reservation for a room that is under maintenance.");
        //}

        if (reservation.CheckInDate > reservation.CheckOutDate)
        {
            throw new ArgumentException("Check-out date must be after check-in date.");
        }

        if (reservation.Status == ReservationStatus.Confirmed)
        {
            Console.WriteLine("Reservation is already confirmed.");
            _reservations.Add(reservation);
            return;
        }
    }

    public void ShowFullHistory()
    {
        Console.WriteLine($"Reservation history for {FullName}:");
        foreach (var reservation in _reservations)
        {
            Console.WriteLine($"Reservation ID: {reservation.ReservationId}," +
                $" Room Number: {reservation.RoomNumber}," +
                $" Check-in: {reservation.CheckInDate.ToShortDateString()}," +
                $" Check-out: {reservation.CheckOutDate.ToShortDateString()}," +
                $" Status: {reservation.Status}");
        }
    }

    public override string ToString()
    {
        return $"Guest ID: {GuestId}, Name: {FullName}, Phone: {PhoneNumber}";
    }



}
