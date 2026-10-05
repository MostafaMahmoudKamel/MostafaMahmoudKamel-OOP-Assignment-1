using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part2_HotelReservationSystem.src;

internal class Reservation
{

    public int ReservationId { get; init; }
    public DateTime CheckInDate { get; init; }

    public DateTime CheckOutDate { get; init; }

    public ReservationStatus Status { get; private set; }
    public Room Room { get; }

    public int RoomNumber { get; init; }

    public Reservation(int reservationId, DateTime checkInDate, DateTime checkOutDate, Room room)
    {
        if (reservationId <= 0)
            throw new ArgumentException("Reservation ID must be positive.", nameof(reservationId));

        if (checkOutDate <= checkInDate)
            throw new ArgumentException("Check-out date must be strictly after check-in date.", nameof(checkOutDate));


        if (room.IsUnderMaintenance)
            throw new InvalidOperationException($"room underMaintenance {room.RoomNumber} ");

        ReservationId = reservationId;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        Status = ReservationStatus.Pending;
    }
    public double CalculateTotalCost()
    {
        int duration = (CheckOutDate - CheckInDate).Days;
        return duration * Room.NightlyRate;
    }

    public void Confirm()
    {
        if (Status != ReservationStatus.Pending)
            throw new InvalidOperationException($"Cannot confirm reservation {ReservationId}: status is '{Status}', expected 'Pending'.");

        Status = ReservationStatus.Confirmed;
    }

    public void CheckIn()
    {
        if (Status != ReservationStatus.Confirmed)
            throw new InvalidOperationException($"Cannot check in reservation {ReservationId}').");

        if (Room.IsUnderMaintenance)
            throw new InvalidOperationException($"Cannot check in: Room .");

        Status = ReservationStatus.checkedIn;
    }

    public void CheckOut()
    {
        if (Status != ReservationStatus.checkedIn)
            throw new InvalidOperationException($"Cannot check out .");

        Status = ReservationStatus.checkedOut;
    }

    public void Cancel()
    {
        if (Status == ReservationStatus.checkedOut)
            throw new InvalidOperationException($"Cannot cancel reservation ");

        if (Status == ReservationStatus.Cancelled)
            throw new InvalidOperationException($"Reservation  is already cancelled.");

        Status = ReservationStatus.Cancelled;
    }

}
