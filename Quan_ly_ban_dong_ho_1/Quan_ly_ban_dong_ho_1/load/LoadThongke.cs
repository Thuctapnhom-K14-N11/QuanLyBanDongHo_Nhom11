using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
    static class LoadThongke
    {
        public static bool check = false;

        static Thongke TK;
        public static Thongke khoitao()
        {
            if (check == false)
            {
                check = true;
                TK = new Thongke();
            }
            else TK.Activate();

            return TK;
        }
    }
}
