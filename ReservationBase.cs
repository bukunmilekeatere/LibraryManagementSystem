// BaseReservation.cs
using LibraryManagementSystem.Interfaces;
using System;

public class BaseReservation : IReservation
{
    public User ReservedBy { get; private set; }
    public IItem ReservedItem { get; private set; }
    public DateTime ReservationDate { get; private set; }
    public string Status { get; private set; }

    public BaseReservation(User reservedBy, IItem reservedItem)
    {
        ReservedBy = reservedBy;
        ReservedItem = reservedItem;
        ReservationDate = DateTime.Now;
        Status = "Active";
    }

    public virtual void CancelReservation()
    {
        Status = "Canceled";
    }

    public virtual void CompleteReservation()
    {
        Status = "Completed";
    }
}
