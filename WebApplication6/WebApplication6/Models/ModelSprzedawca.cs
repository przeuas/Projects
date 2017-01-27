
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class ModelSprzedawca
    {

    }
}

namespace WebApplication6.Models
{

    public class ModelSprzedawcaDBCtxt : DbContext
    {
        public DbSet<ModelSprzedawca> Sprzedawcy { get; set; }
    }
}