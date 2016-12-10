using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace MojaKlasaa
{
    public class MojaKlasa
    {
       
            public void MetodPublic() { }

        private void MeteodaPrivate() { }

        public void MetodaProtected() { }

        internal void InternalMethod() { }

        protected internal void MetodaProtectedInternal() { }

        void JakasMetoda() { }
        }
    


class Demo
{
    public static void Main(string[] args)
    {
        MojaKlasa k = new MojaKlasa();
        k.MetodPublic();
        k.InternalMethod();
            k.MetodaProtectedInternal();
            //k.MetodaPrivate();

            k.MetodaProtected();
            //k.JakasMetoda();




    }
}
}