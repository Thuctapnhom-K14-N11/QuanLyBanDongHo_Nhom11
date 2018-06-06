using Quan_ly_ban_dong_ho_1.load;

namespace Quan_ly_ban_dong_ho_1
{
    partial class fNhanVien
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
            LoadNhanVien.check = false;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dgv_NhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_cmtnd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_sdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_tennhanvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_manhanvien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dgv_NhanVien);
            this.panel12.Location = new System.Drawing.Point(319, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(393, 328);
            this.panel12.TabIndex = 7;
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.Size = new System.Drawing.Size(393, 328);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 328);
            this.panel3.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.buttonX1);
            this.panel13.Controls.Add(this.btnXoa);
            this.panel13.Controls.Add(this.btnSua);
            this.panel13.Controls.Add(this.btnThem);
            this.panel13.Location = new System.Drawing.Point(3, 283);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(293, 42);
            this.panel13.TabIndex = 12;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(228, 10);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(62, 23);
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Tìm kiếm";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(152, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(78, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(3, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.labelX8.Text = "Thông tin nhân viên";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rdb_nu);
            this.panel8.Controls.Add(this.rdb_nam);
            this.panel8.Controls.Add(this.labelX7);
            this.panel8.Location = new System.Drawing.Point(3, 249);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 28);
            this.panel8.TabIndex = 7;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(210, 9);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(39, 17);
            this.rdb_nu.TabIndex = 1;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "Nữ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(109, 8);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(47, 17);
            this.rdb_nam.TabIndex = 1;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "Nam";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(3, 3);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(89, 23);
            this.labelX7.TabIndex = 0;
            this.labelX7.Text = "Giới tính:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtp_ngaysinh);
            this.panel7.Controls.Add(this.labelX6);
            this.panel7.Location = new System.Drawing.Point(3, 215);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 28);
            this.panel7.TabIndex = 6;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.CustomFormat = "MM/dd/yyyy";
            this.dtp_ngaysinh.Location = new System.Drawing.Point(98, 3);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(195, 20);
            this.dtp_ngaysinh.TabIndex = 1;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(3, 3);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(89, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Ngày sinh:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_cmtnd);
            this.panel6.Controls.Add(this.labelX5);
            this.panel6.Location = new System.Drawing.Point(3, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 28);
            this.panel6.TabIndex = 5;
            // 
            // txt_cmtnd
            // 
            // 
            // 
            // 
            this.txt_cmtnd.Border.Class = "TextBoxBorder";
            this.txt_cmtnd.Location = new System.Drawing.Point(98, 5);
            this.txt_cmtnd.MaxLength = 11;
            this.txt_cmtnd.Name = "txt_cmtnd";
            this.txt_cmtnd.Size = new System.Drawing.Size(192, 20);
            this.txt_cmtnd.TabIndex = 1;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(3, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(89, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "CMND:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_sdt);
            this.panel5.Controls.Add(this.labelX4);
            this.panel5.Location = new System.Drawing.Point(3, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 28);
            this.panel5.TabIndex = 4;
            // 
            // txt_sdt
            // 
            // 
            // 
            // 
            this.txt_sdt.Border.Class = "TextBoxBorder";
            this.txt_sdt.Location = new System.Drawing.Point(98, 5);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(192, 20);
            this.txt_sdt.TabIndex = 1;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(3, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Số điện thoại:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_diachi);
            this.panel4.Controls.Add(this.labelX3);
            this.panel4.Location = new System.Drawing.Point(3, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 28);
            this.panel4.TabIndex = 3;
            // 
            // txt_diachi
            // 
            // 
            // 
            // 
            this.txt_diachi.Border.Class = "TextBoxBorder";
            this.txt_diachi.Location = new System.Drawing.Point(98, 5);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(192, 20);
            this.txt_diachi.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(89, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Địa chỉ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_tennhanvien);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 28);
            this.panel2.TabIndex = 2;
            // 
            // txt_tennhanvien
            // 
            // 
            // 
            // 
            this.txt_tennhanvien.Border.Class = "TextBoxBorder";
            this.txt_tennhanvien.Location = new System.Drawing.Point(98, 5);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(192, 20);
            this.txt_tennhanvien.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên nhân viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_manhanvien);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 28);
            this.panel1.TabIndex = 0;
            // 
            // txt_manhanvien
            // 
            // 
            // 
            // 
            this.txt_manhanvien.Border.Class = "TextBoxBorder";
            this.txt_manhanvien.Location = new System.Drawing.Point(98, 5);
            this.txt_manhanvien.MaximumSize = new System.Drawing.Size(9999, 0);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(192, 20);
            this.txt_manhanvien.TabIndex = 1;
            this.txt_manhanvien.TextChanged += new System.EventHandler(this.txt_manhanvien_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã nhân viên:";
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 353);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Name = "fNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Panel panel8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cmtnd;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sdt;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diachi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tennhanvien;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_manhanvien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel13;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_NhanVien;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.RadioButton rdb_nam;
    }
}