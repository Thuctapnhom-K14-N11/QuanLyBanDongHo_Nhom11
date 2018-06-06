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
    public partial class fKhachHang : Office2007Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }
        KhachHangDao dao = new KhachHangDao();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            fThemHoaDon themHoaDon = new fThemHoaDon();
            themHoaDon.mkh = makh;
            themHoaDon.ShowDialog();

        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            dskh.DataSource = dao.getList();
        }

        private void dskh_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dskh.CurrentRow.Index;
            txt_ma.Text = dskh.Rows[index].Cells[0].Value.ToString();
            txt_name.Text = dskh.Rows[index].Cells[1].Value.ToString();

            txt_diachi.Text = dskh.Rows[index].Cells[2].Value.ToString();
            txt_sdt.Text = dskh.Rows[index].Cells[3].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            string name = txt_name.Text;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            if(dao.update(makh,name,diachi,sdt))
            {
                dskh.DataSource = dao.getList();
            }
            else
            {

            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string makh = txt_ma.Text;
            if(dao.delete(makh))
            {
                dskh.DataSource = dao.getList();
            }
            else
            {

            }
        }
    }
}
