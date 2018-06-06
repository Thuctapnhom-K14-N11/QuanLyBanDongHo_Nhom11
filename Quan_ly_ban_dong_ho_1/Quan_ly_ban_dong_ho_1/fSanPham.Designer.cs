using Quan_ly_ban_dong_ho_1.load;

namespace Quan_ly_ban_dong_ho_1
{
    partial class fSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            LoadSanPham.check = false;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataSanPham = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_msp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_Brand = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_Color = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmb_Stype = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.panel7 = new System.Windows.Forms.Panel();
            this.test = new System.Windows.Forms.PictureBox();
            this.images = new System.Windows.Forms.PictureBox();
            this.TenAnh = new DevComponents.DotNetBar.LabelX();
            this.ChonAnh = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_tt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_gia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSanPham)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dataSanPham);
            this.panel12.Location = new System.Drawing.Point(319, 59);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(393, 340);
            this.panel12.TabIndex = 10;
            // 
            // dataSanPham
            // 
            this.dataSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSanPham.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataSanPham.Location = new System.Drawing.Point(0, 0);
            this.dataSanPham.Name = "dataSanPham";
            this.dataSanPham.ReadOnly = true;
            this.dataSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSanPham.Size = new System.Drawing.Size(393, 340);
            this.dataSanPham.TabIndex = 0;
            this.dataSanPham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataSanPham_MouseClick);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonX1);
            this.panel14.Controls.Add(this.search);
            this.panel14.Controls.Add(this.btnTimKiem);
            this.panel14.Location = new System.Drawing.Point(319, 12);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(393, 41);
            this.panel14.TabIndex = 11;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(315, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 17;
            this.buttonX1.Text = "Load";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // search
            // 
            // 
            // 
            // 
            this.search.Border.Class = "TextBoxBorder";
            this.search.Location = new System.Drawing.Point(21, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(210, 20);
            this.search.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(237, 8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_msp);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 28);
            this.panel1.TabIndex = 0;
            // 
            // txt_msp
            // 
            this.txt_msp.Location = new System.Drawing.Point(98, 5);
            this.txt_msp.Name = "txt_msp";
            this.txt_msp.Size = new System.Drawing.Size(192, 20);
            this.txt_msp.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_ten);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 28);
            this.panel2.TabIndex = 2;
            // 
            // txt_ten
            // 
            // 
            // 
            // 
            this.txt_ten.Border.Class = "TextBoxBorder";
            this.txt_ten.Location = new System.Drawing.Point(98, 5);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(192, 20);
            this.txt_ten.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên sản phẩm:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmb_Brand);
            this.panel4.Controls.Add(this.labelX3);
            this.panel4.Location = new System.Drawing.Point(3, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 28);
            this.panel4.TabIndex = 3;
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DisplayMember = "Text";
            this.cmb_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.ItemHeight = 14;
            this.cmb_Brand.Location = new System.Drawing.Point(98, 3);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(192, 20);
            this.cmb_Brand.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(89, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Thương hiệu:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmb_Color);
            this.panel5.Controls.Add(this.labelX4);
            this.panel5.Location = new System.Drawing.Point(3, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 28);
            this.panel5.TabIndex = 4;
            // 
            // cmb_Color
            // 
            this.cmb_Color.DisplayMember = "Text";
            this.cmb_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.ItemHeight = 14;
            this.cmb_Color.Location = new System.Drawing.Point(98, 5);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(192, 20);
            this.cmb_Color.TabIndex = 1;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(3, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Màu sắc:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.labelX8);
            this.panel9.Location = new System.Drawing.Point(4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(293, 28);
            this.panel9.TabIndex = 11;
            // 
            // labelX8
            // 
            this.labelX8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(3, 3);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(286, 23);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "Thông tin sản phẩm";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cmb_Stype);
            this.panel6.Controls.Add(this.labelX5);
            this.panel6.Location = new System.Drawing.Point(3, 181);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 28);
            this.panel6.TabIndex = 12;
            // 
            // cmb_Stype
            // 
            this.cmb_Stype.DisplayMember = "Text";
            this.cmb_Stype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Stype.FormattingEnabled = true;
            this.cmb_Stype.ItemHeight = 14;
            this.cmb_Stype.Location = new System.Drawing.Point(98, 3);
            this.cmb_Stype.Name = "cmb_Stype";
            this.cmb_Stype.Size = new System.Drawing.Size(192, 20);
            this.cmb_Stype.TabIndex = 1;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(3, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(89, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Thể loại:";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(6, 359);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.test);
            this.panel7.Controls.Add(this.images);
            this.panel7.Controls.Add(this.TenAnh);
            this.panel7.Controls.Add(this.ChonAnh);
            this.panel7.Location = new System.Drawing.Point(3, 215);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 70);
            this.panel7.TabIndex = 13;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(205, 4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(85, 63);
            this.test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.test.TabIndex = 4;
            this.test.TabStop = false;
            // 
            // images
            // 
            this.images.Location = new System.Drawing.Point(99, 4);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(85, 63);
            this.images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.images.TabIndex = 3;
            this.images.TabStop = false;
            // 
            // TenAnh
            // 
            this.TenAnh.Location = new System.Drawing.Point(4, 31);
            this.TenAnh.Name = "TenAnh";
            this.TenAnh.Size = new System.Drawing.Size(75, 23);
            this.TenAnh.TabIndex = 2;
            this.TenAnh.Text = "Chưa chọn ảnh";
            // 
            // ChonAnh
            // 
            this.ChonAnh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ChonAnh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ChonAnh.Location = new System.Drawing.Point(4, 2);
            this.ChonAnh.Name = "ChonAnh";
            this.ChonAnh.Size = new System.Drawing.Size(75, 23);
            this.ChonAnh.TabIndex = 0;
            this.ChonAnh.Text = "Chọn ảnh";
            this.ChonAnh.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(102, 359);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_tt);
            this.panel8.Controls.Add(this.labelX7);
            this.panel8.Location = new System.Drawing.Point(4, 291);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 28);
            this.panel8.TabIndex = 14;
            // 
            // txt_tt
            // 
            // 
            // 
            // 
            this.txt_tt.Border.Class = "TextBoxBorder";
            this.txt_tt.Location = new System.Drawing.Point(98, 5);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.Size = new System.Drawing.Size(192, 20);
            this.txt_tt.TabIndex = 1;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(3, 3);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(89, 23);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Thông tin:";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(194, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txt_gia);
            this.panel10.Controls.Add(this.labelX9);
            this.panel10.Location = new System.Drawing.Point(4, 325);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(293, 28);
            this.panel10.TabIndex = 15;
            // 
            // txt_gia
            // 
            // 
            // 
            // 
            this.txt_gia.Border.Class = "TextBoxBorder";
            this.txt_gia.Location = new System.Drawing.Point(98, 5);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(192, 20);
            this.txt_gia.TabIndex = 1;
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(3, 3);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(89, 23);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "Giá:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 387);
            this.panel3.TabIndex = 8;
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 406);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Name = "fSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.fSanPham_Load);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSanPham)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private System.Windows.Forms.DataGridView dataSanPham;
        private DevComponents.DotNetBar.Controls.TextBoxX search;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_msp;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ten;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Brand;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Color;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panel9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_Stype;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private System.Windows.Forms.Panel panel8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tt;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.Panel panel10;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_gia;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.LabelX TenAnh;
        private DevComponents.DotNetBar.ButtonX ChonAnh;
        private System.Windows.Forms.PictureBox images;
        private System.Windows.Forms.PictureBox test;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}