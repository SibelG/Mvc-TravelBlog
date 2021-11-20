using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelBlog.Models.Sınıflar
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string  Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Fax  { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Konum { get; set; }

    }
}