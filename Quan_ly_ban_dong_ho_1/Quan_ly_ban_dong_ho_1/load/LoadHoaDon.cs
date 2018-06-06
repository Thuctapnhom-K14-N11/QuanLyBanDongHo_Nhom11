using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
        static class LoadHoaDon
        {
            public static bool check = false;

            static fHoaDon HD;
            public static fHoaDon khoitao()
            {
                if (check == false)
                {
                    check = true;
                    HD = new fHoaDon();
                }
                else HD.Activate();

                return HD;
            }

        }
}
