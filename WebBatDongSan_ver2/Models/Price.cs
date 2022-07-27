using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class Price
    {
        public int Id { get; set; }
        public string PriceRange { get; set; }
        public int MinValue { get; set; }
        public int Maxvalue { get; set; }
    }
}
