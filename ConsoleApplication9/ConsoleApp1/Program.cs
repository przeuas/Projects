using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Text;

class Example
{
    public static void Main()
    {
        // Create a UTF-8 encoding.
        UTF8Encoding utf8 = new UTF8Encoding();

        // A Unicode string with two characters outside an 8-bit code range.
        String unicodeString =
            "This Unicode string has 2 characters outside the " +
            "ASCII range:\n" +
            " ALEUT KA  (\u051e), and  KOMI DE  (\u0500).";
        Console.WriteLine("Original string:");
        Console.WriteLine(unicodeString);

        // Encode the string.
        Byte[] encodedBytes = utf8.GetBytes(unicodeString);
        Console.WriteLine();
        Console.WriteLine("Encoded bytes:");
        for (int ctr = 0; ctr < encodedBytes.Length; ctr++)
        {
            Console.Write("{0:X2} ", encodedBytes[ctr]);
            if ((ctr + 1) % 25 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();

        // Decode bytes back to string.
        String decodedString = utf8.GetString(encodedBytes);
        Console.WriteLine();
        Console.WriteLine("Decoded bytes:");
        Console.WriteLine(decodedString);

        Console.Read();
    }
}
