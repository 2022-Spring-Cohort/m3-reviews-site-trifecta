using System;

namespace template_csharp_reviews_site.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string  Brand { get; set; }

        public string OSVer { get; set; }

        public double Price { get; set; }   

        public DateTime ReleaseDate { get; set; }   

    }
}
