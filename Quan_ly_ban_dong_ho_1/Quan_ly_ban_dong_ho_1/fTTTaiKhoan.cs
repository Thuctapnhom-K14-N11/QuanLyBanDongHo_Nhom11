using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Quan_ly_ban_dong_ho_1.DAO;
using Quan_ly_ban_dong_ho_1.Connection;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class fTTTaiKhoan : Office2007Form
    {
        public fTTTaiKhoan()
        {
            InitializeComponent();
        }

        DangNhapDAO dao = new DangNhapDAO();
        private void btnSua_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan ttttDao = new ThongTinTaiKhoan();
        }

        private void fTTTaiKhoan_Load(object sender, EventArgs e)
        {
            loadnv();
            
        }

        public void loadnv()
        {
            DataTable table= dao.getbyId(PhanQuyenDao.maNguoiQuanLy);
            txbTenTK.Text = PhanQuyenDao.TenDangNhap;
            txbTenNV.Text = table.Rows[0][1].ToString();
            txbSDT.Text= table.Rows[0][3].ToString();
            txbCMND.Text= table.Rows[0][4].ToString(); 
            txbDiaChi.Text= table.Rows[0][2].ToString();
            dtipNS.Text= table.Rows[0][6].ToString();
            if(table.Rows[0][7].ToString()=="Nam")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }

        }

        
    }
}
