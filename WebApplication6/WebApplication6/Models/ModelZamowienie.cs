using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class ModelZamowienie
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public DateTime data { get; set; }


    }
    public class Platnosc 
    {
       
        public DateTime dataPlatnosci { get; set; }
        bool zrealizowana { get; set; }
        int platnosc { get; set; }
    }
    public class Podsumowanie
    {
        public int iloscBiletow { get; set; }
        public int iloscUlgowych { get; set; }

        public char sektor { get; set; }

        public int Miejsce { get; set; }

        public int Rzad { get; set; }
        public double Cena { get; set; }

        public string  Klient{ get; set; }
        public string sygnatura { get; set; }




    }
    public class Dostawa
    {
        public string typ { get; set; }
        public bool zrealizowana { get; set; }
    }
}

namespace WebApplication6.Models
{
   
    public class ModelZamowienieDBCtxt : DbContext
    {
        public DbSet<ModelZamowienie> Zamowienia { get; set; }
    }
}