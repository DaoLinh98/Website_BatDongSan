using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class InfoCompany
    {
        public int Id { get; set; }
        public string FirstNam { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Addess { get; set; }
        public string HotLine { get; set; }
        public string Slogan { get; set; }
        public string Email { get; set; }
    }
}
