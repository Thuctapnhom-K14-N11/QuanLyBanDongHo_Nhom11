using Quan_ly_ban_dong_ho_1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.DAO
{
    class ThongTinTaiKhoan
    {
        KetNoi ketnoi;

        public ThongTinTaiKhoan()
        {
            ketnoi = new KetNoi();
        }

        public static string GT;

     //   public bool upDateTTTT()
     //   {
     ////       string query = "UPDATE dbo.Direction SET id = N'"+ +"', name = N'', address_ship = N'', phone = N'', identification = N'', email = N'', bith = N'', sex = N'' WHERE id = N''";
     //       return ketnoi.ExecuteNonQuery(query);
     //   }


        public bool getTenNV()
        {
            string query = "SELECT name FROM dbo.UserLogin u, dbo.Direction AS d WHERE u.account = N'"+PhanQuyenDao.TenDangNhap+"' AND d.id = u.id_direction";
            return ketnoi.ExecuteNonQuery(query);
        }

        public bool getDiaChi()
        {
            string query = "SELECT address_ship FROM dbo.UserLogin u, dbo.Direction AS d WHERE u.account = N'" + PhanQuyenDao.TenDangNhap + "' AND d.id = u.id_direction";
            return ketnoi.ExecuteNonQuery(query);
        }

        public bool getSDT()
        {
            string query = "SELECT phone FROM dbo.UserLogin u, dbo.Direction AS d WHERE u.account = N'" + PhanQuyenDao.TenDangNhap + "' AND d.id = u.id_direction";
            return ketnoi.ExecuteNonQuery(query);
        }

        public bool getCMND()
        {
            string query = "SELECT identification FROM dbo.UserLogin u, dbo.Direction AS d WHERE u.account = N'" + PhanQuyenDao.TenDangNhap + "' AND d.id = u.id_direction";
            return ketnoi.ExecuteNonQuery(query);
        }

        //public bool getGT()
        //{
        //    string query = "SELECT sex FROM dbo.UserLogin u, dbo.Direction AS d WHERE u.account = N'" + PhanQuyenDao.TenDangNhap + "' AND d.id = u.id_direction";
        //    return ketnoi.ExecuteNonQuery(query);
        //}

        public bool getNS()
        {
            string query = "SELECT bith FROM dbo.UserLogin u, dbo.Direction AS d WHERE u.account = N'" + PhanQuyenDao.TenDangNhap + "' AND d.id = u.id_direction";
            return ketnoi.ExecuteNonQuery(query);
        }

        //public bool getTenTT()
        //{
        //    string query = "";
        //    return ketnoi.ExecuteNonQuery(query);
        //}
    }
}
