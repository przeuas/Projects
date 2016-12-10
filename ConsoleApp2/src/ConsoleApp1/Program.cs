using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    public class Test 
    {
       
    public static void TestDynamicznych()
    {
        var sw  = System.Diagnostics.Stopwatch.StartNew();
        dynamic a = 100.1;
        dynamic b = 200.1;
        dynamic c = 300.1;
        dynamic d = 400.1;
        dynamic e = 500.1;
        dynamic f = 600.1;
        dynamic g = 700.1;
        dynamic h = 800.1;
        dynamic i = 900.1;

        dynamic wyn = ++a + ++b + ++c + ++d + ++e + ++f + ++h + ++i;

        sw.Stop();

        WriteLine($" Czas zm dynamicznych: { sw.ElapsedTicks }");


    }
    private static void TestStatycznych()
    {
        var sw  = System.Diagnostics.Stopwatch.StartNew();
        double a = 100.1;
        double b = 200.1;
        double c = 300.1;
        double d = 400.1;
        double e = 500.1;
        double f = 600.1;
        double g = 700.1;
        double h = 800.1;
        double i = 900.1;
        WriteLine($" Czas zm statycznych: { sw.ElapsedTicks }");
        }
    public static void Main(string[] args)
    {
        TestDynamicznych();
        TestStatycznych();

        TestDynamicznych();
        TestStatycznych();

        TestDynamicznych();
        TestStatycznych();
        TestDynamicznych();
        TestStatycznych();
        TestDynamicznych();
        TestStatycznych();

            ReadLine();

    }
    }
}
    

