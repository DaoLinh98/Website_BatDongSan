using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class Product
    {
        public Product()
        {
            DetailProducts = new HashSet<DetailProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CatagoryId { get; set; }
        public string Description { get; set; }
        public int? ImageId { get; set; }
        public string PathImage { get; set; }
        public decimal? Acreage { get; set; }
        public decimal? Price { get; set; }
        public int? AreaId { get; set; }
        public int? UnitId { get; set; }
        public string Status { get; set; }
        public int? PriceId { get; set; }
        public string Address { get; set; }

        public virtual Area Area { get; set; }
        public virtual ICollection<DetailProduct> DetailProducts { get; set; }
    }
}
