using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace demoCallerInfo
{
    public class Info
    {
        public void WyswietlDane(string message,[CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFiePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Trace.WriteLine("wiadomosc" + message);
            Trace.WriteLine("nazwa metody" + memberName);
            Trace.WriteLine("plik zrodlowy" + sourceFiePath);
            Trace.WriteLine("numer lini w pliku" + sourceLineNumber);
        }
    }
}
