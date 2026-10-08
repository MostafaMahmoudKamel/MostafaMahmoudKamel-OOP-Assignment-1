using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_OOP_Simulation.Part2_HotelReservationSystem.src;

internal class Room
{

    public int RoomNumber { get; }
    public RoomType RoomType { get; }

    public int NightlyRate { get; private set; }

    public bool IsUnderMaintenance { get; private set; }
    public Room(int roomNumber, RoomType roomType, int intialRoomRate)
    {
        if (intialRoomRate < 0)
        {
            throw new ArgumentException("Nightly rate cannot be negative.");

        }
        RoomNumber = roomNumber;
        RoomType = roomType;
        NightlyRate = intialRoomRate;
        IsUnderMaintenance = false;
    }


    public void StartMaintenance()
    {
        if (IsUnderMaintenance)
            throw new InvalidOperationException($"Room {RoomNumber} is already under maintenance.");

        IsUnderMaintenance = true;
    }

    public void EndMaintenance()
    {
        if (!IsUnderMaintenance)
            throw new InvalidOperationException($"Room {RoomNumber} is not currently under maintenance.");

        IsUnderMaintenance = false;
    }
}
