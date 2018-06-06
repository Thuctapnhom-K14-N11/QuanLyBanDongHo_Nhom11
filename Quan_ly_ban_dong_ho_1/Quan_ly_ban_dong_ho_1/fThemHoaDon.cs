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
    public partial class fThemHoaDon : Office2007Form
    {
        public fThemHoaDon()
        {
            InitializeComponent();
        }
        public string mkh;
        KhachHangDao khachHangDao = new KhachHangDao();
        HoaDonDao dao = new HoaDonDao();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void fThemHoaDon_Load(object sender, EventArgs e)
        {
            DataTable table= khachHangDao.getById(mkh);
            DataRow row = table.Rows[0];
            txbMaKhachHang.Text = row.ItemArray[0].ToString();
            txt_ten.Text = row.ItemArray[1].ToString();
            txt_diachi.Text = row.ItemArray[2].ToString();
            txt_sdt.Text = row.ItemArray[3].ToString();
            ngay.Text = DateTime.Today.ToString();


        }

        private void dssp(object sender, EventArgs e)
        {
           
        }

        private void txbMaHoaDon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themsp_Click(object sender, EventArgs e)
        {
            if (txbMaHoaDon.Text != "")
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.mhd = txbMaHoaDon.Text;
                chiTietHoaDon.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa nhập mã hóa đơn");
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txbMaHoaDon.Text;
            string makh = txbMaKhachHang.Text;
           
            string ngaymua = ngay.Text;
            string gia = tongtien.Text;
            int check = 0;
            if (rb_thanhtoan.Checked) check = 1;
            
            
                if (dao.themHD(mahd, makh, ngaymua, check))
                {
                    
                }
                else
                {
                    
                    MessageBox.Show("Lỗi thêm hóa đơn");
                }
           
        }
    }
}
