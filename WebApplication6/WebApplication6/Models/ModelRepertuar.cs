using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApplication6.Models
{
    public class ModelRepertuar
    {
        public int Id { get; set; }
        public string Lokalizacja { get; set; }
        public string Tytuł { get; set; }

        public string Auror { get; set; }
        public decimal Cena { get; set; }

        public DateTime data { get; set; }
        
    }
  
    public class ModelRepertuarDBCtxt : DbContext
    {
        public DbSet<ModelRepertuar> Reperutary { get; set; }
    }
}