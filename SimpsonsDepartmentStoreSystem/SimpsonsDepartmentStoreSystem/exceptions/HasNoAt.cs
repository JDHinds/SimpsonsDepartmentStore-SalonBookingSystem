using System;

namespace SimpsonsDepartmentStoreSystem.exceptions
{
    class HasNoAt : Exception
    {
        public HasNoAt(string message) : base(message)
        { }
    }
}
