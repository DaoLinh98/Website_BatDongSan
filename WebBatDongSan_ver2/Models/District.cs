using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProvinceId { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsPublished { get; set; }
    }
}
