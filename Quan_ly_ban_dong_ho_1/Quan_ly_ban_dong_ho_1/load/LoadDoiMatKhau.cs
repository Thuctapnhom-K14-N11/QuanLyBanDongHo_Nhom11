using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
    static class LoadDoiMatKhau
    {
        public static bool check = false;

        static fDoiMatKhau DMK;
        public static fDoiMatKhau khoitao_1()
        {
            if (check == false)
            {
                check = true;
                DMK = new fDoiMatKhau();
            }
            else DMK.Activate();

            return DMK;
        }

    }
}
