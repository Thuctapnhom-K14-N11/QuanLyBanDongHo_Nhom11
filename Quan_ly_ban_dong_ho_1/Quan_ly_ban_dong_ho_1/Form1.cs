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
using Quan_ly_ban_dong_ho_1.load;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class Form1 : Office2007RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadKhachHang.khoitao().MdiParent = this;
            LoadKhachHang.khoitao().Show();
            //fKhachHang KH = new fKhachHang();
            //KH.MdiParent = this;
            //KH.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadNhanVien.khoitao().MdiParent = this;
            LoadNhanVien.khoitao().Show();
            
            //fNhanVien NV = new fNhanVien();
            //NV.MdiParent = this;
            //NV.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            LoadSanPham.khoitao().MdiParent = this;
            LoadSanPham.khoitao().Show();
            
            //fSanPham SP = new fSanPham();
            //SP.MdiParent = this;
            //SP.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            LoadHoaDon.khoitao().MdiParent = this;
            LoadHoaDon.khoitao().Show();

            //fHoaDon HD = new fHoaDon();
            //HD.MdiParent = this;
            //HD.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            LoadTTTaiKhoan.khoitao_6().MdiParent = this;
            LoadTTTaiKhoan.khoitao_6().Show();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            LoadDoiMatKhau.khoitao_1().MdiParent = this;
            LoadDoiMatKhau.khoitao_1().Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap dn = new fDangNhap();
            dn.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            LoadThongke.khoitao().MdiParent = this;
            LoadThongke.khoitao().Show();
        }
    }

}
