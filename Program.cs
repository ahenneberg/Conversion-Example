using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# can convert between instances of types that are compatible with one another.
// A conversion always creates a new value from an existing one.
// Conversions can be explicit or implicit

namespace Conversion_Example
{
    class Program
    {
        static void Main()
        {
            int x = 12345;      // int is a 32-bit integer
            // Implicit conversions are allowed when both of the following are true:
                // The compiler can guarantee they will always succeed
                // No info is lost in conversion
            long y = x;         // Implicit conversion to 64-bit integer
            // Conversely, explicit conversions are required when one of the following is true:
                // The compiler CANNOT guarantee they will always succeed
                // Information may be lost during conversion. 
            short z = (short)x; // Explicit conversion to 16-bit integer
        }
    }
}
