using System;

namespace SimpsonsDepartmentStoreSystem.exceptions
{
    class IsTooShort : Exception
    {
        public IsTooShort(string message) : base (message)
        { }
    }
}
