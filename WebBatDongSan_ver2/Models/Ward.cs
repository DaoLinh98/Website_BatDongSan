﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string LatiLongTude { get; set; }
        public int? DistrictId { get; set; }
        public string SortOrder { get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
