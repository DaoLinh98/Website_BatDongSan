using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class DetailProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descriptionn { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
