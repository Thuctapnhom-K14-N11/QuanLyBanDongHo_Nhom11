using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DevComponents.DotNetBar;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class Thongke : Office2007RibbonForm
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.thongke", con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            SqlCommand cmd2 = new SqlCommand("SELECT PRICE FROM dbo.thongke", con);
            SqlDataReader rd2 = cmd2.ExecuteReader();

            Series sr = new Series();
            while (rd2.Read())
            {
                chart1.Series[0].Points.AddY(rd2.GetDouble(0));


            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            fThongke thongke = new fThongke();
            int index = dataGridView1.CurrentRow.Index;
            thongke.thang = dataGridView1.Rows[index].Cells[0].Value.ToString();
            thongke.ShowDialog();
        }
    }
}
