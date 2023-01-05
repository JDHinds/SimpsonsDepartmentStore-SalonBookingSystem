using System;

namespace SimpsonsDepartmentStoreSystem.exceptions
{
    class IsAfterToday : Exception
    {
        public IsAfterToday(string message) : base (message)
        {}
    }
}
