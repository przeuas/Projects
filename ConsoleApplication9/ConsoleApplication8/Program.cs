using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Numerics;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("arytmetyka duzych liczb");

            BigInteger bi0 = new BigInteger();
            WriteLine($"Wartosc bi0:) { bi0}");
            BigInteger bi1 = new BigInteger(12345678901234565789);

            BigInteger bi11 = BigInteger.Parse("99999999999999999999");

            WriteLine($"Wartosc b1 {bi1}");
            WriteLine($"parzystosc bi1 { bi1.IsEven}");

            WriteLine($"bi1 potega dwójki {bi1.IsPowerOfTwo}");

            BigInteger bi2 = BigInteger.Multiply(bi1, BigInteger.Parse("8888888888888888888888888888"));

            WriteLine($"Iloczyn b1 x bi2: {bi2}");


            WriteLine(1.0.GetTypeCode());
            WriteLine(1E06.GetTypeCode());
            WriteLine(1.GetTypeCode());
            WriteLine(0xF00000000.GetTypeCode());
            WriteLine(1.0F.GetTypeCode());
            WriteLine(1D.GetTypeCode());
            WriteLine(1.0M.GetTypeCode());
            WriteLine(1U.GetTypeCode());
            WriteLine(1UL.GetTypeCode());
            WriteLine(1L.GetTypeCode());
            WriteLine('A'.GetTypeCode());
            WriteLine('\u0041'.GetTypeCode());
            WriteLine('\x0041'.GetTypeCode());


            WriteLine("aa".GetTypeCode());
            WriteLine(1.0.GetTypeCode());


            var name = "adam abacki";
            var age = 25;
            var boss = false;

            Type nameType = name.GetType();
            Type ageTpye = age.GetType();

            WriteLine($"name type {nameType.ToString()}");
            WriteLine($"age type {ageTpye.ToString()}");



            int i = 123;
            object oi = new object();
            WriteLine($"typy: \n i {i.GetType()} \n {oi.GetType()}");

            oi = i;
            int j = (int)oi;

            WriteLine($"\n i {i} \n i {oi} , {j} {i.GetType()} \n {oi.GetType()} \nj {j.GetType()}");


            ReadKey();



        }
    }
}
