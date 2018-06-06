using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
    static class LoadTTTaiKhoan
    {
        public static bool check = false;

        static fTTTaiKhoan TTTK;
        public static fTTTaiKhoan khoitao_6()
        {
            if (check == false)
            {
                check = true;
                TTTK = new fTTTaiKhoan();
            }
            else TTTK.Activate();

            return TTTK;
        }

    }
}
