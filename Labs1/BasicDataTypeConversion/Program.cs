using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypeConversion
{
    class Program
    {
        //Sr.No.Methods & Description
        //    ToBoolean: Converts a type to a Boolean value, where possible.
        //    ToByte: Converts a type to a byte.
        //    ToChar: Converts a type to a single Unicode character, where possible.
        //    ToDateTime: Converts a type (integer or string type) to date-time structures.
        //    ToDecimal: Converts a floating point or integer type to a decimal type.
        //    ToDouble: Converts a type to a double type.
        //    ToInt16: Converts a type to a 16-bit integer.
        //    ToInt32: Converts a type to a 32-bit integer.
        //    ToInt64: Converts a type to a 64-bit integer.
        //    ToSbyte: Converts a type to a signed byte type.
        //    ToSingle: Converts a type to a small floating point number.
        //    ToString: Converts a type to a string.
        //    ToType: Converts a type to a specified type.
        //    ToUInt16: Converts a type to an unsigned int type.
        //    ToUInt32: Converts a type to an unsigned long type.
        //    ToUInt64: Converts a type to an unsigned big integer.


        static void Main(string[] args)
        {
            double doubleNumber = 1.14567;
            int integerNumber;

            integerNumber = (int)doubleNumber;

            Console.WriteLine("Double number convert to Integer number: {0}", integerNumber);
            Console.ReadLine();
        }
    }
}
