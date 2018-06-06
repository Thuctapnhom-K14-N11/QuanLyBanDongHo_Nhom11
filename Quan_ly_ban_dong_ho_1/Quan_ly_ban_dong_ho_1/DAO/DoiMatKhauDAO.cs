using Quan_ly_ban_dong_ho_1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.DAO
{
    class DoiMatKhauDAO
    {
        KetNoi ketnoi;
        public DoiMatKhauDAO()
            {
            ketnoi = new KetNoi();
            } 

        public bool UpDateMk(string ten_TK, string MK)
        {
            string query = "UPDATE dbo.UserLogin SET password =N'"+MK+"' WHERE account = N'"+ten_TK+"'";
            return ketnoi.ExecuteNonQuery(query);
        }
        public DataTable CheckMK(string ten_TK, string MK)
        {
            string query = "SELECT * FROM dbo.UserLogin WHERE account='" + ten_TK + "' AND password='" + MK + "'";

            return ketnoi.ExecuteQuery(query);
        }
    }
}
