using Quan_ly_ban_dong_ho_1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.DAO
{
    class HoaDonDao
    {
        KetNoi ketNoi;
        public HoaDonDao()
        {
            ketNoi = new KetNoi();
        }
        public DataTable getListHD()
        {
            string query = "SELECT b.id N'Mã HD',cus.id N'Mã khách hàng', cus.name N'Khách hàng',cus.address_ship N'Địa điểm',cus.phone N'Phone',B.date N'Ngày mua',B.total N'Tổng tiền',B.trangthai N'Trạng thái' FROM dbo.Bill B, dbo.Customer cus WHERE b.id_Cus = cus.id  ";
            return ketNoi.ExecuteQuery(query);
        }
        public bool addHD()
        {
            string query = "";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool updateHD(string mahd,string makh,string ngaymua,string gia,string check)
        {
            string query = " UPDATE dbo.Bill SET  id_Cus = '"+ makh + "', date = '"+ngaymua+"' ,total = "+gia+",trangthai = "+check+" WHERE id = '"+mahd+"'";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool deleteHD(string mahd)
        {
            string query = " DELETE dbo.Bill WHERE id='"+mahd+"'";
            return ketNoi.ExecuteNonQuery(query);
        }
        public DataTable getListmua(string mahd)
        {
            string query = "SELECT id_Product N'Mã sản phẩm',quantity N'Số lượng' FROM dbo.Bill_Details WHERE id_bill= '" + mahd + "'";
            return ketNoi.ExecuteQuery(query);
        }
        public bool themKH(string mkh, string tenkh, string diachi, string sdt)
        {
            string query = "INSERT dbo.Customer VALUES  ( '" + mkh + "' ,  N'" + tenkh + "' , N'" + diachi + "' ,  '" + sdt + "' )";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool themHD(string mahd, string mkh, string ngaymua, int trangthai)
        {
            string query = "INSERT dbo.Bill( id, id_Cus, date, trangthai )VALUES  ( '"+mahd+"',  '"+mkh+"', '"+ngaymua+"'  , "+trangthai+"   )";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool themchitiet(string mhd,string masp,string sl,string gia)
        {
            string query= "INSERT dbo.Bill_Details(id_Product, id_bill,price , quantity)VALUES('" + masp+"', '"+mhd+"',"+Convert.ToDouble(gia)*Convert.ToInt32(sl)+","+sl+")";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool xoachitiet(string mhd, string masp)

        {
            string query = "DELETE dbo.Bill_Details WHERE id_Product='"+masp+"' AND id_bill='"+mhd+"'";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool xoaKH(string makh)
        {
            string query = "DELETE dbo.Customer WHERE id='"+makh+"'";
            return ketNoi.ExecuteNonQuery(query);
        }
        public bool xoaHD(string mhd)
        {
            string query = "DELETE dbo.Bill WHERE id='" + mhd + "'";
            return ketNoi.ExecuteNonQuery(query);
        }
        public string getPrice(string mhd)
        {
            string query = "SELECT SUM(price) FROM dbo.Bill_Details GROUP BY id_bill HAVING id_bill='"+mhd+"'";


           DataTable table= ketNoi.ExecuteQuery(query);

            return table.Rows[0][0].ToString();
        }



    }
}
