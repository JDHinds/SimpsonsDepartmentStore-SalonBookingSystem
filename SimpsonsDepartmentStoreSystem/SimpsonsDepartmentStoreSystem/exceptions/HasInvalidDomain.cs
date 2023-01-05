using System;

namespace SimpsonsDepartmentStoreSystem.exceptions
{
    class HasInvalidDomain : Exception
    {
        public HasInvalidDomain(string message) : base(message)
        { }
    }
}