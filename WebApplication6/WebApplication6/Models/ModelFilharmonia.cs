using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class ModelFilharmonia
    {

    }
}

namespace WebApplication6.Models
{

    public class ModelFilharmoniaDBCtxt : DbContext
    {
        public DbSet<ModelFilharmonia> Filharmonia { get; set; }
    }
}