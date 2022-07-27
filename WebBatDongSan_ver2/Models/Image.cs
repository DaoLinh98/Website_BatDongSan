using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string PathImage { get; set; }
    }
}
