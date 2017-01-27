using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class ModelSpektakl:ModelRepertuar
    {
       
        public int IDs { get; set;}
        public string Wykonawcy { get; set; }
        public string ImgUrl { get; set; }

        //public Bitmap Image { get; set; }

    }
    public class ModelSpektaklDBCtxt : DbContext
    {
        public DbSet<ModelSpektakl> Spektakle { get; set; }
    }
}