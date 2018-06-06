using Quan_ly_ban_dong_ho_1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_ban_dong_ho_1.DAO
{
    class SanPhamDao
    {
        KetNoi ketnoi; 

        public SanPhamDao()
        {
            ketnoi = new KetNoi();
        }

        public DataTable getBrand()
        {
            string query = "SELECT id,name FROM dbo.Brand";
            return ketnoi.ExecuteQuery(query);
        }

        public DataTable getColor()
        {
            string query = "SELECT id,name FROM dbo.Color";
            return ketnoi.ExecuteQuery(query);
        }
        public DataTable getStype()
        {
            string query = "SELECT id,name FROM dbo.stype";
            return ketnoi.ExecuteQuery(query);
        }
        public DataTable getListSP()
        {
            string query = "SELECT sp.id N'Mã SP',sp.name N'Tên',br.name N'Thương hiệu',cl.name N'Màu sắc',st.name N'Thể loại',sp.image N'Hình ảnh',sp.price N'Giá',sp.info N'Thông tin', di.name N'Người nhập' FROM dbo.Product sp, dbo.Brand br,dbo.Color cl,dbo.stype st,dbo.Direction di WHERE sp.id_brand = br.id AND sp.id_color = cl.id AND sp.id_stype = st.id AND sp.id_Direction = di.id";
            return ketnoi.ExecuteQuery(query);
        }

        public bool addSP(string masp,string idBrand,string idColor,string idStype,string imagename,string tt,string gia,string name,string idDirection)
        {
            string query = "INSERT dbo.Product VALUES  ( '"+masp+"' ,  '"+idBrand+"' ,  '"+idColor+"' , '"+idStype+"' , '"+imagename+"' , N'"+tt+"' , "+gia+"  ,  N'"+name+"' ,   '"+idDirection+"' )";
            return ketnoi.ExecuteNonQuery(query);
        }
        public bool UpdateSP(string masp, string idBrand, string idColor, string idStype, string imagename, string tt, string gia, string name, string idDirection)
        {
            string query = "UPDATE dbo.Product SET id_brand='"+idBrand+"',id_color='"+idColor+"',id_stype='"+idStype+"',image='"+imagename+"',info=N'"+tt+"',price="+gia+",name=N'"+name+"',id_Direction=N'"+idDirection+ "'  WHERE id='" + masp + "'" ;
            
            return ketnoi.ExecuteNonQuery(query);
        }

        public bool DeleleSP(string masp)
        {
            string query = "DELETE dbo.Product WHERE id='"+masp+"'";
            return ketnoi.ExecuteNonQuery(query);   
        }
        public DataTable seach(string name)
        {
            string query = "SELECT  P.id N'Mã SP',P.name N'Tên',B.name N'Thương hiệu',C.name N'Màu sắc',S.name N'Thể loại',P.image N'Hình ảnh',P.price N'Giá',P.info N'Thông tin', di.name N'Người nhập' FROM dbo.Product P,dbo.Brand B,dbo.Color C,dbo.stype S,dbo.Direction di WHERE   B.id = P.id_brand AND C.id = P.id_color AND S.id = P.id_stype AND (B.name LIKE N'"+name+ "%' OR  S.name LIKE N'" + name + "%' OR C.name LIKE N'" + name + "%')AND P.id_Direction = di.id";
            return ketnoi.ExecuteQuery(query);
        }
    }
}
