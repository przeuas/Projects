using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array0;
            array0 = new int[3];

            int[] array1 = new int[3];

            int[] array2 = new int[3] { 1, 3, 4 };
            int[] array3 = { 1, 2, 4 };

            int[,] tab2d1 = new int[2, 3];

            int[,] tab2d2 =  { { 0, 1 }, { 3, 4} };
            int[,,] tab3d = { { { 1, 2 }, { 3, 4 } }
                            ,{ { 5,6 },{ 7,8} },
                              { { 9,10},{ 11,12 } } };

            foreach (var ii in tab2d1) Write($"{ii,4}");
            WriteLine("\n");

            foreach(var ii in tab2d2)Write($"{ii,4}");
            WriteLine("\n");

            foreach (var ii in tab3d) Write($"{ii,4}");
            WriteLine("\n");

            

            int[][] jagged = new int [3][];;
            jagged[0] = new int[2];
            jagged[0][0] = 1;
            jagged[0][1] = 2;
            jagged[1] = new int[6];
            jagged[2] = new int[3] { 3, 4, 5 };

            for(int i = 0;i<jagged.Length;i++)
            {
                int[] innerArray = jagged[i];
                for (int ia = 0; ia < innerArray.Length; ia++)
                {
                    Write($"{innerArray[ia],4}");
                }
                WriteLine();
            }
            Read();
        }
    }
}
