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
    public partial class fDSHoaDon : Office2007Form
    {
        public fDSHoaDon()
        {
            InitializeComponent();
        }
        HoaDonDao dao = new HoaDonDao();
        string mahd;
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemHoaDon don = new fThemHoaDon();

            don.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }
        public void loadDS()
        {
            DataTable table = new DataTable();
            table = dao.getListHD();
            dtgvDSHoaDon.DataSource = table;
        }

        private void dtgvDSHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dtgvDSHoaDon.CurrentRow.Index;
            mahd = dtgvDSHoaDon.Rows[index].Cells[0].Value.ToString();
        }

        private void fDSHoaDon_Load(object sender, EventArgs e)
        {
            
            loadDS();
        }
    }
}
