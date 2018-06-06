using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.load
{
    static class LoadKhachHang
    {
      public static bool check = false;

       static fKhachHang KH;
       public static fKhachHang khoitao()
        {
            if (check == false)
            {
                check = true;
                KH = new fKhachHang();
            }
            else KH.Activate();

            return KH;
        }
    }
}
