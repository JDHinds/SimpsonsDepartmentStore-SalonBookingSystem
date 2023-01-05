using System;

namespace SimpsonsDepartmentStoreSystem.exceptions
{
    class HasNumber : Exception
    {
        public HasNumber(string message) : base(message)
        { }
    }
}