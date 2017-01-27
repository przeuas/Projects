
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class ModelKlient
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string email { get; set; }

        public string telefon { get; set; }

    }
}

namespace WebApplication6.Models
{

    public class ModelKlientDBCtxt : DbContext
    {
        public DbSet<ModelKlient> Klienci { get; set; }
    }
}