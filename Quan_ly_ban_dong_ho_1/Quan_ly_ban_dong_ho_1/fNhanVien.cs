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
using System.Data.SqlClient;
//using app = Microsoft.Office.Interop.Excel.Application;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class fNhanVien : Office2007Form
    {
        bool themmoi = false;
       
        public fNhanVien()
        {
            InitializeComponent();
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
           // Show_CboGT("");
            Show_Nhanvien("");
        }
        //cbb gt
        /*
        private void Show_CboGT(string ID)
        {
            string sql="Select ID, SEX From DIRECTION";
            if (ID != "")
            sql = sql + " Where ID='" + ID + "'";
            SqlDataAdapter daNhanVien = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            daNhanVien.Fill(dt);

            cboGT.DataSource = dt;
            cboGT.ValueMember = "ID";
            cboGT.DisplayMember = "SEX";
        }        private void cboGT_Click(object sender, EventArgs e)
            {
                 Show_CboGT("");
            }
        */
        private void Show_Nhanvien(string MA_NV)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            string sql = "Select * From DIRECTION";
            if (MA_NV != "")
                sql = sql + " Where ID ='" + MA_NV + "'";
            SqlDataAdapter daNhanvien = new SqlDataAdapter(sql, kn);
            DataTable dt1 = new DataTable();
            daNhanvien.Fill(dt1);
            dgv_NhanVien.DataSource = dt1;
        }

        // tang ma
        /*
          public string TangMa()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            string sql = " select * from DIRECTION";
            SqlCommand cm = new SqlCommand(sql, kn);
            cm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int k = 1;
            string Ma = "QL0" + k;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string MaNV = dt.Rows[i]["ID"].ToString().Trim();
                if(MaNV == Ma)
                {
                    k = k + 1;
                    if (k < 10)
                    {
                        Ma = "QL0" + k;
                    }
                    else
                    {
                        Ma = "QL" + k;
                    }
                }
            }
            return Ma;
        }
         */


        /*
        public void Mo_btn()
        {
            //các txt mở lại để nhập
            txt_manhanvien.ReadOnly = false;
            txt_tennhanvien.ReadOnly = false;
            txt_diachi.ReadOnly = false;
            txt_sdt.ReadOnly = false;
            txt_cmtnd.ReadOnly = false;
        }
        public void Khoa_btn()
        {
            //các txt khóa, ko cho nhập 
            txt_manhanvien.ReadOnly = true;
            txt_tennhanvien.ReadOnly = true;
            txt_diachi.ReadOnly = true;
            txt_sdt.ReadOnly = true;
            txt_cmtnd.ReadOnly = true;
        }
        */
        public void SetNull()
        {
            txt_manhanvien.Text = "";
            txt_tennhanvien.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_cmtnd.Text = "";
        }
        public void ketnoi()
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            
            string sql = "Select * from dbo.DIRECTION";
            SqlCommand commandsql = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            dgv_NhanVien.DataSource = data;
            kn.Close();
        }
        public void themNV(string manv, string tennv,string diachi, string sdt, string cmtnd, string gt, string ngaysinh)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            try
            {
                string sql = "INSERT dbo.DIRECTION( ID , NAME, ADDRESS_SHIP, PHONE, IDENTIFICATION, BITH, SEX) VALUES  ( '" + manv + "' , N'" + tennv + "' ,N'" + diachi + "',N'" + sdt + "', N'" + cmtnd + "','" + ngaysinh + "' , " + gt + "    )";


                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                kn.Close();
            }
            catch
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            // txt_manhanvien.Text = TangMa();
            ketnoi();

        }
        public void SuaNV(string manv, string tennv, string diachi, string sdt, string cmtnd, string gt, string ngaysinh)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();

            try
            {
                string sql = "UPDATE dbo.DIIRECTION SET NAME=N'" + tennv + "',PHONE=N'" + sdt + "',ADDRESS=N'" + diachi + "',IDENTIFICTION=N'" + cmtnd + "',BITH='" + ngaysinh + "',SEX=' " + gt + "'  WHERE ID='" + manv + "'";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                kn.Close();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi mời kiểm tra lại thông tin");
            }
            ketnoi();
        }

        public void XoaNV(string manv)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();

            try
            {
                string sql = "DELETE dbo.DIRECTION WHERE ID='" + manv + "'";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                kn.Close();
            }
            catch
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }
            ketnoi();
        }
        private void txt_manhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            //Khoa_btn();
            ketnoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            //Mở nút thêm
            txt_manhanvien.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //txt_manhanvien.Text = TangMa();



            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            SqlCommand cmd = new SqlCommand("ThemNV", kn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaNV", txt_manhanvien.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@TenNV", txt_tennhanvien.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@DiaChi", txt_diachi.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@SDT", txt_sdt.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@CMTND", txt_cmtnd.Text);
            cmd.Parameters.Add(p);

            if (rdb_nam.Checked)
               p = new SqlParameter("@GT", "Nam");
            else
                p = new SqlParameter("@GT", "Nu");
            cmd.Parameters.Add(p);

            /*
             cboGT.SelectedValue.ToString());
             cmd.Parameters.Add(p);
             */

            p = new SqlParameter("@NgaySinh", dtp_ngaysinh.Value.Year.ToString() + "-" +
            dtp_ngaysinh.Value.Month.ToString() + "-" + dtp_ngaysinh.Value.Day.ToString());
            cmd.Parameters.Add(p);


            // Thực thi thủ tục 
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                Show_Nhanvien("");
            }
            else MessageBox.Show("Không thể thêm mới");

            txt_manhanvien.Focus();
           // Mo_btn();
            SetNull();
            kn.Close();

            /*  
            string manv = txt_manhanvien.Text;
            string tennv = txt_tennhanvien.Text;
            string gt = "-1";
            if (rdb_nam.Checked == true) gt = "Nam";
            if (rdb_nu.Checked == true) gt = "Nu";
            string ngaysinh = dtp_NgaySinh.Value.ToString();
            if (manv == "" || tennv == "" || gt == "-1" || ngaysinh == "") MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
            else themNV(manv, tennv, gt, ngaysinh);
            */
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            if (txt_manhanvien.Text == "")
            {
                MessageBox.Show("Chưa chọn nhân viên để sửa!");
                return;
            }
           // Mo_btn();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            //hienthi ds Ma nhanvien
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            SqlCommand cmd = new SqlCommand("SuaNV", kn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaNV", txt_manhanvien.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@TenNV", txt_tennhanvien.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@DiaChi", txt_diachi.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@SDT", txt_sdt.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@CMTND", txt_cmtnd.Text);
            cmd.Parameters.Add(p);

            if (rdb_nam.Checked)
                p = new SqlParameter("@GT", "Nam");
            else
                p = new SqlParameter("@GT", "Nu");
            cmd.Parameters.Add(p);

            /*
             cboGT.SelectedValue.ToString());
             cmd.Parameters.Add(p);
             */

            p = new SqlParameter("@NgaySinh", dtp_ngaysinh.Value.Year.ToString() + "-" +
            dtp_ngaysinh.Value.Month.ToString() + "-" + dtp_ngaysinh.Value.Day.ToString());
            cmd.Parameters.Add(p);

            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
                Show_Nhanvien("");
            }
            else MessageBox.Show("Không thể sửa được");
            kn.Close();
            //
            //string manv = txt_manhanvien.Text;
            //string tennv = txt_tennhanvien.Text;
            //string gt = "-1";
            //if (rdb_nam.Checked == true) gt = "Nam";
            //if (rdb_nu.Checked == true) gt = "Nu";
            //string ngaysinh = dtp_NgaySinh.Value.ToString();

            //if (manv == "" || tennv == "" || gt == "-1" || ngaysinh == "") MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
            //else SuaNV(manv, tennv, gt, ngaysinh);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
                kn.Open();
                SqlCommand cmd = new SqlCommand("XoaNV", kn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaNV", txt_manhanvien.Text);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công");
                ketnoi();
                //
                //string manv = txt_manhanvien.Text;
                //XoaNV(manv);
            }
        }
        // luu click
        /*
          private void bt_luu_Click(object sender, EventArgs e)
            {
                if (txt_manhanvien.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin");
                    return;
                }
                else
                {
                    //Them NV
                    if (themmoi == true)

                        // { 
                        try
                        {
                            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
                            kn.Open();
                            SqlCommand cmd = new SqlCommand("ThemNV", kn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter p = new SqlParameter("@MaNV", txt_manhanvien.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@TenNV", txt_tennhanvien.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@DiaChi", txt_diachi.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@SDT", txt_sdt.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@CMTND", txt_cmtnd.Text);
                            cmd.Parameters.Add(p);

                            if (rdb_nam.Checked)
                            p = new SqlParameter("@GT", "Nam");
                            else
                            p = new SqlParameter("@GT", "Nu");
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@NgaySinh", dtp_ngaysinh.Value.Year.ToString() + "-" +
                            dtp_ngaysinh.Value.Month.ToString() + "-" + dtp_ngaysinh.Value.Day.ToString());
                            cmd.Parameters.Add(p);


                            cmd.ExecuteNonQuery();
                            //Hiển thị lại thông tin sau khi thêm và thông báo
                            ketnoi();
                            MessageBox.Show("Thêm mới thành công");

                        //
                            
                            bt_luu.Enabled = false;
                            bt_sua.Enabled = true;
                            bt_xoa.Enabled = true;
                            SetNull();
                            kn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    //Sua Nhan Vien
                    else
                    {
                        try
                        {
                            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
                            kn.Open();
                            //MessageBox.Show("ok");

                            SqlCommand cmd2 = new SqlCommand("SuaNV", kn);
                            cmd2.CommandType = CommandType.StoredProcedure;

                           SqlParameter p = new SqlParameter("@MaNV", txt_manhanvien.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@TenNV", txt_tennhanvien.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@DiaChi", txt_diachi.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@SDT", txt_sdt.Text);
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@CMTND", txt_cmtnd.Text);
                            cmd.Parameters.Add(p);

                            if (rdb_nam.Checked)
                            p = new SqlParameter("@GT", "Nam");
                            else
                            p = new SqlParameter("@GT", "Nu");
                            cmd.Parameters.Add(p);

                            p = new SqlParameter("@NgaySinh", dtp_ngaysinh.Value.Year.ToString() + "-" +
                            dtp_ngaysinh.Value.Month.ToString() + "-" + dtp_ngaysinh.Value.Day.ToString());
                            cmd.Parameters.Add(p);

                            cmd2.ExecuteNonQuery();

                            //Hiển thị lại thông tin sau khi thêm và thông báo
                            //Ketnoi();

                            MessageBox.Show("Thay đổi thông tin nhân viên thành công");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    bt_them.Enabled = true;
                    bt_luu.Enabled = false;
                    bt_xoa.Enabled = true;
                    SetNull();
                    
                    ketnoi();
                }
            }
         */
        public void TimKiemTheoMa(string manv)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();

            string sql = "SELECT * FROM dbo.DIRECTION WHERE ID ='" + manv + "'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            dgv_NhanVien.DataSource = data;

            kn.Close();
        }
        public void TimKiemTheoTen(string tennv)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();

            string sql = "SELECT * FROM dbo.DIRECTION WHERE NAME ='" + tennv + "'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter con = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            con.Fill(data);
            dgv_NhanVien.DataSource = data;
            kn.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string manv = txt_manhanvien.Text;
            string tennv = txt_tennhanvien.Text;
            string gt = "-1";
            if (rdb_nam.Checked == true) gt = "Nam";
            if (rdb_nu.Checked == true) gt = "Nữ";
            string ngaysinh = dtp_ngaysinh.Value.ToString();
            if (manv == "")
                if (tennv == "")
                    MessageBox.Show("Mời nhập thông tin để tìm kiếm");
                else TimKiemTheoTen(tennv);
            else TimKiemTheoMa(manv);
        }
        // timkiem click
        /*
          private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLDH;Integrated Security=True");
            kn.Open();
            if (txtTimKiem.Text != "")
            {
                if (rdTimKiemMa.Checked == true)
                {
                    string sql = "Select * From DIRECTION WHERE ID LIKE'%" + txtTimKiem.Text + "%'";
                    SqlCommand comm = new SqlCommand(sql, kn);
                    SqlDataAdapter ad = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dgv_NhanVien.DataSource = dt;
                }
                if (rdTimKiemTen.Checked == true)
                {
                    string sql = "Select* From DIRECTION WHERE NAME LIKE N'% " + txtTimKiem.Text + "%'";
                    SqlCommand comm = new SqlCommand(sql, kn);
                    SqlDataAdapter ad = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dgv_NhanVien.DataSource = dt;
                }
            }
        }
         */
         // dien gtri cot stt
        /*
            private void dgvNhanVien_RowPrePaint(object sender,DataGridViewRowPrePaintEventArgs e)
            {
                dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex +1;
            }
         */
        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgv_NhanVien.CurrentRow.Index;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)

            {
                txt_manhanvien.Text = dgv_NhanVien.Rows[index].Cells[0].Value.ToString();
                txt_tennhanvien.Text = dgv_NhanVien.Rows[index].Cells[1].Value.ToString();
                dtp_ngaysinh.Text = dgv_NhanVien.Rows[index].Cells[6].Value.ToString();
                txt_cmtnd.Text = dgv_NhanVien.Rows[index].Cells[4].Value.ToString();
                txt_diachi.Text = dgv_NhanVien.Rows[index].Cells[2].Value.ToString();
                txt_sdt.Text = dgv_NhanVien.Rows[index].Cells[3].Value.ToString();
                // cmb_lp.Text= dgv_NhanVien.Rows[index].Cells["7"].Value.ToString();
                string gt = dgv_NhanVien.CurrentRow.Cells["SEX"].Value.ToString().Trim();
                if (gt == "Nam")
                {
                    rdb_nam.Checked = true;
                    rdb_nu.Checked = false;
                 }
                else
                {
                    rdb_nam.Checked = false;
                    rdb_nu.Checked = true;
                 }


            }

        }
        //xuat excel
        /*
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

         private void btnEx_Click(object sender, EventArgs e)
        {
            export2Excel(dtg_ThongKe, @"D:\", "Thong ke");
            MessageBox.Show("Đã Xuất");
        }
        */
        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
