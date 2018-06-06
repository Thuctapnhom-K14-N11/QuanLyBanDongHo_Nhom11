using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
    static class LoadSanPham
    {
        public static bool check = false;
        static fSanPham SP;

        public static fSanPham khoitao()
        {
            if (check == false)
            {
                check = true;
                SP = new fSanPham();
            }
            else SP.Activate();

            return SP;
        }
    }
}
