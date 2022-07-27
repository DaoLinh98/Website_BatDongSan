using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class Area
    {
        public Area()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
