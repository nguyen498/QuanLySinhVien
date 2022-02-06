
namespace QuanLySinhVien
{
    partial class fDangKyHocPhan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCaNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuâtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvMonHoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvMonDaDangKy = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHuyDangKyDKHP = new System.Windows.Forms.Button();
            this.btnDangKyDKHP = new System.Windows.Forms.Button();
            this.cbFilterSelect = new System.Windows.Forms.ComboBox();
            this.txtSearchMonHocClient = new System.Windows.Forms.TextBox();
            this.btnSearchMonHocClient = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonDaDangKy)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTaiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCaNhânToolStripMenuItem,
            this.đăngXuâtToolStripMenuItem});
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCaNhânToolStripMenuItem
            // 
            this.thôngTinCaNhânToolStripMenuItem.Name = "thôngTinCaNhânToolStripMenuItem";
            this.thôngTinCaNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCaNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCaNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCaNhânToolStripMenuItem_Click);
            // 
            // đăngXuâtToolStripMenuItem
            // 
            this.đăngXuâtToolStripMenuItem.Name = "đăngXuâtToolStripMenuItem";
            this.đăngXuâtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuâtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuâtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuâtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 27);
            this.panel1.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Lọc theo Khoa",
            "Lọc theo Môn Học"});
            this.cbFilter.Location = new System.Drawing.Point(4, 4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(373, 21);
            this.cbFilter.TabIndex = 0;
            this.cbFilter.Text = "Chọn danh sách lọc";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvMonHoc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 308);
            this.panel3.TabIndex = 4;
            // 
            // dtgvMonHoc
            // 
            this.dtgvMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonHoc.Location = new System.Drawing.Point(0, 24);
            this.dtgvMonHoc.Name = "dtgvMonHoc";
            this.dtgvMonHoc.Size = new System.Drawing.Size(377, 305);
            this.dtgvMonHoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Môn Học";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvMonDaDangKy);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(398, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 253);
            this.panel4.TabIndex = 5;
            // 
            // dtgvMonDaDangKy
            // 
            this.dtgvMonDaDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMonDaDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonDaDangKy.Location = new System.Drawing.Point(4, 24);
            this.dtgvMonDaDangKy.Name = "dtgvMonDaDangKy";
            this.dtgvMonDaDangKy.Size = new System.Drawing.Size(277, 250);
            this.dtgvMonDaDangKy.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn đã đăng ký";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHuyDangKyDKHP);
            this.panel5.Controls.Add(this.btnDangKyDKHP);
            this.panel5.Location = new System.Drawing.Point(399, 346);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 47);
            this.panel5.TabIndex = 6;
            // 
            // btnHuyDangKyDKHP
            // 
            this.btnHuyDangKyDKHP.Location = new System.Drawing.Point(124, 4);
            this.btnHuyDangKyDKHP.Name = "btnHuyDangKyDKHP";
            this.btnHuyDangKyDKHP.Size = new System.Drawing.Size(75, 40);
            this.btnHuyDangKyDKHP.TabIndex = 0;
            this.btnHuyDangKyDKHP.Text = "Hủy đăng ký";
            this.btnHuyDangKyDKHP.UseVisualStyleBackColor = true;
            this.btnHuyDangKyDKHP.Click += new System.EventHandler(this.btnHuyDangKyDKHP_Click);
            // 
            // btnDangKyDKHP
            // 
            this.btnDangKyDKHP.Location = new System.Drawing.Point(205, 4);
            this.btnDangKyDKHP.Name = "btnDangKyDKHP";
            this.btnDangKyDKHP.Size = new System.Drawing.Size(75, 40);
            this.btnDangKyDKHP.TabIndex = 0;
            this.btnDangKyDKHP.Text = "Đăng ký";
            this.btnDangKyDKHP.UseVisualStyleBackColor = true;
            this.btnDangKyDKHP.Click += new System.EventHandler(this.btnDangKyDKHP_Click);
            // 
            // cbFilterSelect
            // 
            this.cbFilterSelect.FormattingEnabled = true;
            this.cbFilterSelect.Location = new System.Drawing.Point(16, 59);
            this.cbFilterSelect.Name = "cbFilterSelect";
            this.cbFilterSelect.Size = new System.Drawing.Size(373, 21);
            this.cbFilterSelect.TabIndex = 0;
            this.cbFilterSelect.SelectedIndexChanged += new System.EventHandler(this.cbFilterSelect_SelectedIndexChanged);
            // 
            // txtSearchMonHocClient
            // 
            this.txtSearchMonHocClient.Location = new System.Drawing.Point(402, 59);
            this.txtSearchMonHocClient.Name = "txtSearchMonHocClient";
            this.txtSearchMonHocClient.Size = new System.Drawing.Size(196, 20);
            this.txtSearchMonHocClient.TabIndex = 7;
            // 
            // btnSearchMonHocClient
            // 
            this.btnSearchMonHocClient.Location = new System.Drawing.Point(604, 59);
            this.btnSearchMonHocClient.Name = "btnSearchMonHocClient";
            this.btnSearchMonHocClient.Size = new System.Drawing.Size(79, 20);
            this.btnSearchMonHocClient.TabIndex = 8;
            this.btnSearchMonHocClient.Text = "Tìm";
            this.btnSearchMonHocClient.UseVisualStyleBackColor = true;
            this.btnSearchMonHocClient.Click += new System.EventHandler(this.btnSearchMonHocClient_Click);
            // 
            // fDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 428);
            this.Controls.Add(this.btnSearchMonHocClient);
            this.Controls.Add(this.txtSearchMonHocClient);
            this.Controls.Add(this.cbFilterSelect);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Môn Học";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonHoc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonDaDangKy)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCaNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuâtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDangKyDKHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyDangKyDKHP;
        private System.Windows.Forms.DataGridView dtgvMonHoc;
        private System.Windows.Forms.DataGridView dtgvMonDaDangKy;
        private System.Windows.Forms.ComboBox cbFilterSelect;
        private System.Windows.Forms.TextBox txtSearchMonHocClient;
        private System.Windows.Forms.Button btnSearchMonHocClient;
    }
}