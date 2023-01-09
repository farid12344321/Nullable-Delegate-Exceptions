using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Delegate__Exceptions_Practices
{
    internal class InvalidLoginException : Exception
    {
        public InvalidLoginException(string message):base(message) { }
    }
}
