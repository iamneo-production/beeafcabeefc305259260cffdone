using System;

namespace dotnetapp.Exceptions
{
    public class SlotBookingException : Exception
{
    public SlotBookingException(string message) : base(message)
    {
    }
}
}