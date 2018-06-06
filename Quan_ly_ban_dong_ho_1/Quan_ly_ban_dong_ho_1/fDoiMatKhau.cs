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

namespace Quan_ly_ban_dong_ho_1
{
    public partial class fDoiMatKhau : Office2007Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }
        DataTable table;
        DoiMatKhauDAO dao = new DoiMatKhauDAO();
        DangNhapDAO DAO = new DangNhapDAO();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten_TK = txbTenTK.Text;
            string MK_Cu = txbMKCu.Text;
            string MK_Moi = txbMKMoi.Text;
            string Nhap_Lai = txbNhapLai.Text;
            table = dao.CheckMK(ten_TK, MK_Cu);
            if (table.Rows.Count > 0)
            {
                if (MK_Moi == Nhap_Lai)
                {
                    dao.UpDateMk(ten_TK, MK_Moi);
                    MessageBox.Show("Cập nhật thành công!");
                }
                else { MessageBox.Show("Mật khẩu mới không khớp!"); }
            }
            else { MessageBox.Show("Mật khẩu không chính xác!"); }
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            LoadDMK();
        }
        public void LoadDMK()
        {
            DataTable table = DAO.getbyId(PhanQuyenDao.maNguoiQuanLy);
            txbTenTK.Text = PhanQuyenDao.TenDangNhap;
        }
    }
}
