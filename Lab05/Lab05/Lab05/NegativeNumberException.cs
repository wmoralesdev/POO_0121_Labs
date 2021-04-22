using System;

namespace Lab05
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string? message) : base(message)
        {
        }
    }
}