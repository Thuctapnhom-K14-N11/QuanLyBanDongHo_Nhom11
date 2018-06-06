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
using Quan_ly_ban_dong_ho_1.Connection;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class fThongke : Form
    {
        public fThongke()
        {
            InitializeComponent();
        }
        public string thang;
        KetNoi ketNoi=new KetNoi();

        private void fThongke_Load(object sender, EventArgs e)
        {
            string query = "EXEC dbo.thongke_thang @thang = '" + thang + "'";
            dataGridView1.DataSource = ketNoi.ExecuteQuery(query);
        }
    }
}
