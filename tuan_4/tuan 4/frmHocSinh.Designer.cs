namespace tuan_4
{
    partial class frmHocSinh
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
            this.lMSHS = new System.Windows.Forms.Label();
            this.lHoTen = new System.Windows.Forms.Label();
            this.lDiaChi = new System.Windows.Forms.Label();
            this.lNgaySinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnPhai = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuuFile = new System.Windows.Forms.Button();
            this.vMAHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMsHocSinh = new System.Windows.Forms.TextBox();
            this.txtTenHocSinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.MSHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lMSHS
            // 
            this.lMSHS.AutoSize = true;
            this.lMSHS.Location = new System.Drawing.Point(31, 45);
            this.lMSHS.Name = "lMSHS";
            this.lMSHS.Size = new System.Drawing.Size(65, 13);
            this.lMSHS.TabIndex = 0;
            this.lMSHS.Text = "Mã học sinh";
            // 
            // lHoTen
            // 
            this.lHoTen.AutoSize = true;
            this.lHoTen.Location = new System.Drawing.Point(31, 75);
            this.lHoTen.Name = "lHoTen";
            this.lHoTen.Size = new System.Drawing.Size(82, 13);
            this.lHoTen.TabIndex = 1;
            this.lHoTen.Text = "Họ tên học sinh";
            // 
            // lDiaChi
            // 
            this.lDiaChi.AutoSize = true;
            this.lDiaChi.Location = new System.Drawing.Point(31, 143);
            this.lDiaChi.Name = "lDiaChi";
            this.lDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lDiaChi.TabIndex = 2;
            this.lDiaChi.Text = "Địa chỉ";
            // 
            // lNgaySinh
            // 
            this.lNgaySinh.AutoSize = true;
            this.lNgaySinh.Location = new System.Drawing.Point(31, 112);
            this.lNgaySinh.Name = "lNgaySinh";
            this.lNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lNgaySinh.TabIndex = 3;
            this.lNgaySinh.Text = "Ngày sinh";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(16, 28);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 4;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(16, 56);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 5;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // btnPhai
            // 
            this.btnPhai.Controls.Add(this.radNam);
            this.btnPhai.Controls.Add(this.radNu);
            this.btnPhai.Location = new System.Drawing.Point(350, 40);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(200, 100);
            this.btnPhai.TabIndex = 6;
            this.btnPhai.TabStop = false;
            this.btnPhai.Text = "Phái";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(603, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(603, 75);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(603, 104);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Location = new System.Drawing.Point(603, 138);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new System.Drawing.Size(75, 23);
            this.btnLuuFile.TabIndex = 10;
            this.btnLuuFile.Text = "Lưu File";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // vMAHS
            // 
            this.vMAHS.HeaderText = "Mã số học sinh";
            this.vMAHS.Name = "vMAHS";
            // 
            // vHoTen
            // 
            this.vHoTen.HeaderText = "Họ Tên";
            this.vHoTen.Name = "vHoTen";
            // 
            // vPhai
            // 
            this.vPhai.HeaderText = "Phái";
            this.vPhai.Name = "vPhai";
            // 
            // vDiaChi
            // 
            this.vDiaChi.HeaderText = "Địa chỉ";
            this.vDiaChi.Name = "vDiaChi";
            // 
            // txtMsHocSinh
            // 
            this.txtMsHocSinh.Location = new System.Drawing.Point(131, 42);
            this.txtMsHocSinh.Name = "txtMsHocSinh";
            this.txtMsHocSinh.Size = new System.Drawing.Size(100, 20);
            this.txtMsHocSinh.TabIndex = 12;
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(131, 77);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(100, 20);
            this.txtTenHocSinh.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(131, 143);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 14;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(131, 107);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSHS,
            this.HoTen,
            this.NgaySinh,
            this.Phai});
            this.dgvHocSinh.Location = new System.Drawing.Point(22, 194);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(572, 150);
            this.dgvHocSinh.TabIndex = 16;
            // 
            // MSHS
            // 
            this.MSHS.HeaderText = "Mã số học sinh";
            this.MSHS.Name = "MSHS";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên học sinh";
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Phai
            // 
            this.Phai.HeaderText = "Phái";
            this.Phai.Name = "Phai";
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenHocSinh);
            this.Controls.Add(this.txtMsHocSinh);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.lNgaySinh);
            this.Controls.Add(this.lDiaChi);
            this.Controls.Add(this.lHoTen);
            this.Controls.Add(this.lMSHS);
            this.Name = "frmHocSinh";
            this.Text = "Form Học Sinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.btnPhai.ResumeLayout(false);
            this.btnPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMSHS;
        private System.Windows.Forms.Label lHoTen;
        private System.Windows.Forms.Label lDiaChi;
        private System.Windows.Forms.Label lNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox btnPhai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.TextBox txtMsHocSinh;
        private System.Windows.Forms.TextBox txtTenHocSinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn vMAHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn vHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn vPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDiaChi;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phai;
    }
}

