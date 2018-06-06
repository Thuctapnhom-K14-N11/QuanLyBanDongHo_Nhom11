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
    public partial class fDangNhap : Office2007Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        DataTable table;
        DangNhapDAO dao = new DangNhapDAO();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txbTenDangNhap.Text;
            string MatKhau = txbMatKhau.Text;
            table = dao.DangNhap(TenDangNhap, MatKhau);
            if(table.Rows.Count>0)
            {
                PhanQuyenDao.TenDangNhap = table.Rows[0][0].ToString();
                PhanQuyenDao.quyen = table.Rows[0][1].ToString();
                PhanQuyenDao.maNguoiQuanLy = table.Rows[0][3].ToString();
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không chính xác");
            }
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
