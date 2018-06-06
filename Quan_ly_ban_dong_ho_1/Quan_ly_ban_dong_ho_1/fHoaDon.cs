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
    public partial class fHoaDon : Office2007Form
    {
        public fHoaDon()
        {
            InitializeComponent();
        }
        HoaDonDao dao = new HoaDonDao();
        private void themsp_Click(object sender, EventArgs e)
        {
            if (txbMaHoaDon.Text != "")
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.mhd = txbMaHoaDon.Text;
                chiTietHoaDon.ShowDialog();
                tongtien.Text = dao.getPrice(txbMaHoaDon.Text);

            }
        }

        private void txbMaHoaDon_TextAlignChanged(object sender, EventArgs e)
        {
            themsp.Enabled = true;
        }
        public void loadDS()
        {
            DataTable table = new DataTable();
            table = dao.getListHD();
            dshd.DataSource = table;
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            loadDS();
        }

        private void dshd_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dshd.CurrentRow.Index;
            txbMaHoaDon.Text = dshd.Rows[index].Cells[0].Value.ToString();
            txbMaKhachHang.Text= dshd.Rows[index].Cells[1].Value.ToString();
            txt_tenkh.Text= dshd.Rows[index].Cells[2].Value.ToString();
            txt_diachi.Text= dshd.Rows[index].Cells[3].Value.ToString();
            txt_sdt.Text= dshd.Rows[index].Cells[4].Value.ToString();
            ngay.Text= dshd.Rows[index].Cells[5].Value.ToString();
            if (dshd.Rows[index].Cells[6].Value.ToString() == "") tongtien.Text = "0";
            else
            {
                tongtien.Text = dshd.Rows[index].Cells[6].Value.ToString();
            }
            if (dshd.Rows[index].Cells[7].Value.ToString() == "True") rb_thanhtoan.Checked = true;
            else rb_chuathanhtoan.Checked = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahd = txbMaHoaDon.Text;
            string makh = txbMaKhachHang.Text;
            string tenkh = txt_tenkh.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            string ngaymua = ngay.Text;
            string gia = tongtien.Text;
            int check=0;
            if (rb_thanhtoan.Checked) check = 1;
            if (rb_chuathanhtoan.Checked) check = 0;
            if(dao.themKH(makh,tenkh,diachi,sdt))
            {
                if(dao.themHD(mahd,makh,ngaymua,check))
                {
                    setNull();
                    loadDS();
                }
                else
                {
                    dao.xoaKH(makh);
                    MessageBox.Show("Lỗi thêm hóa đơn");
                }
            }
            else
            {
                MessageBox.Show("Lỗi thêm khách hàng");
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            string mhd = txbMaHoaDon.Text;
            if(dao.xoaHD(mhd))
            {
                MessageBox.Show("Xóa thành công");
                setNull();
                loadDS();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi mời thử lại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string mahd = txbMaHoaDon.Text;
           
            string makh = txbMaKhachHang.Text;
            
            string ngaymua = ngay.Text;
            double gia = Convert.ToDouble(tongtien.Text);
            int check = 0;
            if (rb_thanhtoan.Checked) check = 1;
            if (rb_chuathanhtoan.Checked) check = 0;

            if(dao.updateHD(mahd, makh, ngaymua, gia.ToString(), check.ToString()))
            {
                MessageBox.Show("Thành công");
                setNull();
                loadDS();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi mời thử lại");
            }



        }

        public void setNull()
        {
            txbMaHoaDon.Text = "";
            txbMaKhachHang.Text = "";
            txt_tenkh.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            rb_chuathanhtoan.Checked = false;
            rb_thanhtoan.Checked = false;
            tongtien.Text = "0";
        }
    }
}
