
using static System.Console;
using static System.Text.Encoding;

public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("Hello");
        OutputEncoding = GetEncoding("UTF-8");
        WriteLine("czyli witaj swiecie");
        Read();
    }
}

