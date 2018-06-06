using Quan_ly_ban_dong_ho_1.load;

namespace Quan_ly_ban_dong_ho_1
{
    partial class fKhachHang
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
            LoadKhachHang.check = false;
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_sdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ma = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dskh = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dskh)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 328);
            this.panel3.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnXoa);
            this.panel13.Controls.Add(this.btnSua);
            this.panel13.Controls.Add(this.btnThem);
            this.panel13.Location = new System.Drawing.Point(3, 283);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(293, 42);
            this.panel13.TabIndex = 13;
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(215, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(125, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(21, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm hóa đơn";
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
            this.labelX8.Text = "Thông tin khách hàng";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_sdt);
            this.panel5.Controls.Add(this.labelX4);
            this.panel5.Location = new System.Drawing.Point(3, 180);
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
            this.panel4.Location = new System.Drawing.Point(3, 146);
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
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(3, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 28);
            this.panel2.TabIndex = 2;
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.Border.Class = "TextBoxBorder";
            this.txt_name.Location = new System.Drawing.Point(98, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(192, 20);
            this.txt_name.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(89, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên khách hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ma);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 28);
            this.panel1.TabIndex = 0;
            // 
            // txt_ma
            // 
            // 
            // 
            // 
            this.txt_ma.Border.Class = "TextBoxBorder";
            this.txt_ma.Location = new System.Drawing.Point(98, 5);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(192, 20);
            this.txt_ma.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(3, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(89, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã khách hàng:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dskh);
            this.panel12.Location = new System.Drawing.Point(319, 59);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(393, 281);
            this.panel12.TabIndex = 4;
            // 
            // dskh
            // 
            this.dskh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dskh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dskh.Location = new System.Drawing.Point(0, 0);
            this.dskh.Name = "dskh";
            this.dskh.Size = new System.Drawing.Size(393, 281);
            this.dskh.TabIndex = 0;
            this.dskh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dskh_MouseClick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.buttonX1);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(319, 12);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(393, 40);
            this.panel10.TabIndex = 9;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(311, 6);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Tìm kiếm";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.textBoxX7);
            this.panel11.Controls.Add(this.labelX9);
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(293, 28);
            this.panel11.TabIndex = 7;
            // 
            // textBoxX7
            // 
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Location = new System.Drawing.Point(98, 5);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.Size = new System.Drawing.Size(192, 20);
            this.textBoxX7.TabIndex = 1;
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(3, 3);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(89, 23);
            this.labelX9.TabIndex = 0;
            this.labelX9.Text = "Nhập thông tin:";
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 347);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Name = "fKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            this.panel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dskh)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sdt;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diachi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_name;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ma;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.Panel panel10;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Panel panel11;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.DataGridView dskh;
    }
}