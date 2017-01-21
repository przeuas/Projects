using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication3
{
    class Program
    {
        const string fn = @"s\robo.txt";
        static void Main(string[] args)
        {
            OutputTarget ot = new OutputTarget();
            Func<string, string, bool> methodCall = ot.SendToFile;

            if (methodCall(fn, "witaj swiecie!"))
                Console.WriteLine("sukces zapisu do pliku" + fn);
            else
                Console.WriteLine("Nieudana operacja zapisu do pliku");
            Console.Read();
        }
        
    }
    public class OutputTarget
    {
        public bool SendToFile(string fn,string st)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fn);
                sw.WriteLine(st);
                sw.Close();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
