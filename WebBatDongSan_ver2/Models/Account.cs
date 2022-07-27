using System;
using System.Collections.Generic;

#nullable disable

namespace WebBatDongSan_ver2.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public decimal? Phone { get; set; }
        public string Password { get; set; }
        public string Satl { get; set; }
        public bool Active { get; set; }
        public DateTime? CreatDate { get; set; }
        public int? RoleId { get; set; }
        public DateTime? LatsLogin { get; set; }
        public virtual Role Role { get; set; }
    }
}
