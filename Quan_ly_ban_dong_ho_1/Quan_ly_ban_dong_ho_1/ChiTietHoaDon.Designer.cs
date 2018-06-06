namespace Quan_ly_ban_dong_ho_1
{
    partial class ChiTietHoaDon
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dssp = new System.Windows.Forms.DataGridView();
            this.dsmua = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_soluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.txt_masp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dssp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsmua)).BeginInit();
            this.SuspendLayout();
            // 
            // dssp
            // 
            this.dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssp.Location = new System.Drawing.Point(12, 89);
            this.dssp.Name = "dssp";
            this.dssp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dssp.Size = new System.Drawing.Size(338, 292);
            this.dssp.TabIndex = 0;
            this.dssp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dssp_MouseClick);
            // 
            // dsmua
            // 
            this.dsmua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsmua.Location = new System.Drawing.Point(588, 89);
            this.dsmua.Name = "dsmua";
            this.dsmua.Size = new System.Drawing.Size(240, 292);
            this.dsmua.TabIndex = 1;
            this.dsmua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsmua_CellContentClick);
            this.dsmua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dsmua_MouseClick);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(378, 134);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Số lượng";
            // 
            // txt_soluong
            // 
            // 
            // 
            // 
            this.txt_soluong.Border.Class = "TextBoxBorder";
            this.txt_soluong.Location = new System.Drawing.Point(442, 134);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(101, 20);
            this.txt_soluong.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(375, 231);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Thêm";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(490, 231);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.TabIndex = 5;
            this.buttonX2.Text = "Xóa";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(442, 284);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.TabIndex = 6;
            this.buttonX3.Text = "Hoàn tất";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // txt_masp
            // 
            // 
            // 
            // 
            this.txt_masp.Border.Class = "TextBoxBorder";
            this.txt_masp.Location = new System.Drawing.Point(442, 105);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(101, 20);
            this.txt_masp.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(378, 105);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Mã Sp";
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 393);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dsmua);
            this.Controls.Add(this.dssp);
            this.Name = "ChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChiTietHoaDon";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dssp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsmua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dssp;
        private System.Windows.Forms.DataGridView dsmua;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_soluong;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_masp;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}