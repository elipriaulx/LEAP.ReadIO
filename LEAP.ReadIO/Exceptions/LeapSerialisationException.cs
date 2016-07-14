using System;
using LEAP.Core.Exceptions;

namespace LEAP.ReadIO.Exceptions
{
    public class LeapSerialisationException : LeapException
    {
        public LeapSerialisationException()
        {

        }

        public LeapSerialisationException(string message) : base(message)
        {

        }

        public LeapSerialisationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
