using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class ModelSpektakl:ModelRepertuar
    {
       
        public int IDs { get; set;}
        public string Wykonawcy { get; set; }

        public string Picture { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Display(Name = "Display profile Image")]
        public bool DisplayItem { get; set; }
        //public Bitmap Image { get; set; }

    }
    public class ModelSpektaklDBCtxt : DbContext
    {
        public DbSet<ModelSpektakl> Spektakle { get; set; }
    }
}