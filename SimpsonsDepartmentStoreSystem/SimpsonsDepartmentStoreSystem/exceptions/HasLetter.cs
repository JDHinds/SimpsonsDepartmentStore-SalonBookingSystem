using System;

namespace SimpsonsDepartmentStoreSystem.exceptions
{
    class HasLetter : Exception
    {
        public HasLetter(string message) : base(message)
        { }
    }
}