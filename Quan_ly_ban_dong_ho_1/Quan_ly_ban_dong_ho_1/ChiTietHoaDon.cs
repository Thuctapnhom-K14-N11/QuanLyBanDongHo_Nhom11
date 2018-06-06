using Quan_ly_ban_dong_ho_1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class ChiTietHoaDon : Form
    {
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public string mhd="";
        string gia;
        HoaDonDao dao = new HoaDonDao();
        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dsmua.DataSource =dao.getListmua(mhd);
            dssp.DataSource = new SanPhamDao().getListSP();

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dssp_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dssp.CurrentRow.Index;
            txt_masp.Text = dssp.Rows[index].Cells[0].Value.ToString();
            gia= dssp.Rows[index].Cells[6].Value.ToString();
        }

        private void dsmua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsmua_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dsmua.CurrentRow.Index;
            txt_masp.Text = dsmua.Rows[index].Cells[0].Value.ToString();
            txt_soluong.Text=dsmua.Rows[index].Cells[1].Value.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            string masp = txt_masp.Text;
            string soluong = txt_soluong.Text;
            if(dao.themchitiet(mhd,masp,soluong,gia))
            {
                dsmua.DataSource = dao.getListmua(mhd);
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string masp = txt_masp.Text;
            if(dao.xoachitiet(mhd,masp))
            {
                dsmua.DataSource = dao.getListmua(mhd);
            }
            else
            {

            }
        }
    }
}
