
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class ModelKoszyk
    {

        public int Id { get; set; }
        public int iloscBiletow { get; set; }
        public int iloscUlgowych { get; set; }

        public char sektor { get; set; }

        public int Miejsce { get; set; }

        public int Rzad { get; set; }
        public double Cena { get; set; }

    }
    
}


namespace WebApplication6.Models
{

    public class ModelKoszykDBCtxt : DbContext
    {
        public DbSet<ModelKoszyk> Koszyki{ get; set; }
    }
}