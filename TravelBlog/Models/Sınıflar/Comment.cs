using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelBlog.Models.Sınıflar
{
    public class Comment
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Comments { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}