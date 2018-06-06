using DevComponents.DotNetBar;
using Quan_ly_ban_dong_ho_1.DAO;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quan_ly_ban_dong_ho_1
{
    public partial class fSanPham : Office2007Form
    {
        public fSanPham()
        {
            InitializeComponent();
        }
        SanPhamDao dao = new SanPhamDao();
        bool check = false;
        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        string urlnameluu;
        private void fSanPham_Load(object sender, EventArgs e)
        {
            CmbBrand();
            CmbStype();
            CmbColor();
            getListSP();

        }

        public void CmbBrand()
        {
            DataTable cmbBrand = new SanPhamDao().getBrand();
            cmb_Brand.DataSource = cmbBrand;
            cmb_Brand.ValueMember = "id";
            cmb_Brand.DisplayMember = "name";
        }
        public void CmbColor()
        {
            DataTable cmbColor = new SanPhamDao().getColor();
            cmb_Color.DataSource = cmbColor;
            cmb_Color.ValueMember = "id";
            cmb_Color.DisplayMember = "name";
        }
        public void CmbStype()
        {
            DataTable cmbStype = new SanPhamDao().getStype();
            cmb_Stype.DataSource = cmbStype;
            cmb_Stype.ValueMember = "id";
            cmb_Stype.DisplayMember = "name";
        }

        public void getListSP()
        {

            DataTable list = new SanPhamDao().getListSP();
            dataSanPham.DataSource = list;
        }

        private void dataSanPham_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int index = dataSanPham.CurrentRow.Index;
            txt_msp.Text = dataSanPham.Rows[index].Cells[0].Value.ToString();
            txt_ten.Text = dataSanPham.Rows[index].Cells[1].Value.ToString();
            cmb_Brand.Text = dataSanPham.Rows[index].Cells[2].Value.ToString();
            cmb_Color.Text = dataSanPham.Rows[index].Cells[3].Value.ToString();
            cmb_Stype.Text = dataSanPham.Rows[index].Cells[4].Value.ToString();
            string imagename = dataSanPham.Rows[index].Cells[5].Value.ToString();
            TenAnh.Text = imagename;

            try
            {
                Bitmap bitmap = new Bitmap(paths + "\\Images\\" + imagename);
                images.Image = bitmap;
            }
            catch
            {

            }
            txt_tt.Text = dataSanPham.Rows[index].Cells[7].Value.ToString();
            txt_gia.Text = dataSanPham.Rows[index].Cells[6].Value.ToString();
        }

        public void setNull()
        {
            txt_msp.Text = "";
            txt_ten.Text = "";
            txt_tt.Text = "";
            txt_gia.Text = "";
            TenAnh.Text = "Chưa chọn ảnh";
            images.Image = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string msp = txt_msp.Text;
            string tensp = txt_ten.Text;
            string idBrand = cmb_Brand.SelectedValue.ToString();
            string idColor = cmb_Color.SelectedValue.ToString();
            string idStype = cmb_Stype.SelectedValue.ToString();
            string tt = txt_tt.Text;
            double gia = Convert.ToDouble(txt_gia.Text);


            if (dao.addSP(msp, idBrand, idColor, idStype, TenAnh.Text, tt, gia.ToString(), tensp, PhanQuyenDao.maNguoiQuanLy))
            {


                System.IO.File.Copy(urlnameluu, paths + "\\Images\\" + TenAnh.Text);
                MessageBox.Show("Đã thêm thành công");
                setNull();
                getListSP();
            }
            else

                MessageBox.Show("Xảy ra lỗi mời thử lại");


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string msp = txt_msp.Text;
            string tensp = txt_ten.Text;
            string idBrand = cmb_Brand.SelectedValue.ToString();
            string idColor = cmb_Color.SelectedValue.ToString();
            string idStype = cmb_Stype.SelectedValue.ToString();
            string tt = txt_tt.Text;
            string gia = txt_gia.Text;
            if (dao.UpdateSP(msp, idBrand, idColor, idStype, TenAnh.Text, tt, gia.ToString(), tensp, PhanQuyenDao.maNguoiQuanLy))
            {

               if(check)
                {
                    System.IO.File.Copy(urlnameluu, paths + "\\Images\\" + TenAnh.Text);
                    check = false;
                }




                MessageBox.Show("Đã sửa thành công");
                setNull();
                getListSP();
            }
            else

                MessageBox.Show("Xảy ra lỗi mời thử lại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masp = txt_msp.Text;
            if (dao.DeleleSP(masp))
            {
                MessageBox.Show("Đã Xóa");
                setNull();
                getListSP();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi mời thử lại");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "";
            open.Filter = "Image Files (*.jpg)|*.jpg|Image Files (*.png)|*.png|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string CorrectFilename = System.IO.Path.GetFileName(open.FileName);
                    Bitmap bitmap = new Bitmap(open.FileName);
                    TenAnh.Text = CorrectFilename;

                    bool check = true;
                    int i = 1;
                    while (check)
                    {
                        try
                        {
                            Bitmap bitmap1 = new Bitmap(paths + "\\Images\\" + TenAnh.Text);
                            TenAnh.Text = "(" + i + ")" + CorrectFilename;
                            i++;
                        }
                        catch
                        {
                            check = false;
                        }
                    }
                    images.Image = bitmap;

                    urlnameluu = open.FileName;
                    check = true;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string name = search.Text;
            dataSanPham.DataSource = dao.seach(name);
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            getListSP();
        }
    }
}
