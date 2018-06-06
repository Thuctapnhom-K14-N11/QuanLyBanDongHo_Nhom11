using Quan_ly_ban_dong_ho_1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.DAO
{
    class KhachHangDao
    {
        KetNoi ketNoi;

        public KhachHangDao()
        {
            ketNoi = new KetNoi();
        }

        public DataTable getById(string id)
        {
            string query = "SELECT id N'Mã khách hàng',name N'Tên khách hàng',address_ship N'Địa chỉ',phone N'SDT' FROM dbo.Customer WHERE id='"+id+"'";
            return ketNoi.ExecuteQuery(query);
        }
        public DataTable getList()
        {
            string query = "SELECT id N'Mã khách hàng',name N'Tên khách hàng',address_ship N'Địa chỉ',phone N'SDT' FROM dbo.Customer";
            return ketNoi.ExecuteQuery(query);
        }
        public bool update(string makh,string name,string diachi, string phone)
        {
            string query = "UPDATE dbo.Customer SET name='"+name+"',address_ship='"+diachi+"',phone='"+phone+ "' WHERE id='"+makh+"'";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool delete(string makh)
        {
            string query = "DELETE dbo.Customer WHERE id='"+makh+"'";
            return ketNoi.ExecuteNonQuery(query);
        }
    }
}
