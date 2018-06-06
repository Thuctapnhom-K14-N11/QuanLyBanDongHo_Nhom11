using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
    static class LoadNhanVien
    {
        public static bool check = false;

        static fNhanVien NV;
        public static fNhanVien khoitao()
        {
            if (check == false)
            {
                check = true;
                NV = new fNhanVien();
            }
            else NV.Activate();

            return NV;
        }

    }
}
