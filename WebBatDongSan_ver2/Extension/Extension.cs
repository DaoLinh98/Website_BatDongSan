using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBatDongSan_ver2.Extension
{
    public static class Extension
    {
        public static string ToVnd(this double donGia)
        {
            return donGia.ToString("#,##0") + " đ";//5.000 đ
        }

    }
}
