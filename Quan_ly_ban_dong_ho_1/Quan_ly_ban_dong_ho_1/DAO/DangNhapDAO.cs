using Quan_ly_ban_dong_ho_1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.DAO
{
    class DangNhapDAO
    {
        

       


        KetNoi ketNoi;
        public DangNhapDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable DangNhap(string TenDangNhap, string MatKhau)
        {
            string query = "SELECT * FROM dbo.UserLogin WHERE account='"+TenDangNhap+"' AND password='"+MatKhau+"'";

            return ketNoi.ExecuteQuery(query);

            
        }
        public DataTable getbyId(string mnv)
        {
            string query = "SELECT * FROM dbo.Direction WHERE id='"+mnv+"'";
            return ketNoi.ExecuteQuery(query);
        }
        //string query = "EXEC dbo.DangNhap @name = '"+TenDangNhap+"', @password = '"+MatKhau+"'";
    }
}
